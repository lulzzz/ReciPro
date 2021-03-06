// EigenFuncs.cpp : DLL アプリケーション用にエクスポートされる関数を定義します。
//

#include "stdafx.h"

/*----------------*/
/* EigenFuncs.cpp */
/*----------------*/
// EigenFuncs.cpp : DLL アプリケーション用にエクスポートされる関数を定義します。
//

#define EIGEN_NO_DEBUG // コード内のassertを無効化．
//#define EIGEN_NO_STATIC_ASSERT
//#define EIGEN_STACK_ALLOCATION_LIMIT 0
//#define EIGEN_RUNTIME_NO_MALLOC

//#define EIGEN_DONT_VECTORIZE // SIMDを無効化．
//#define EIGEN_DONT_PARALLELIZE // 並列を無効化．
//#define EIGEN_MALLOC_ALREADY_ALIGNED 1
//#define EIGEN_FAST_MATH 1
//#define EIGEN_STRONG_INLINE
//#define EIGEN_INITIALIZE_MATRICES_BY_ZERO
//#define EIGEN_USE_MKL_ALL

#define EIGENFUNCS_EXPORTS

//#include <complex>
#include <stdio.h>
#include <string.h>
#include <vector>
#include "math.h"

#include <Eigen/Core>
#include <Eigen/Dense>
#include <Eigen/Geometry>
#include <Eigen/LU>
#include <Eigen/Eigenvalues>
#include "EigenFuncs.h"

using namespace Eigen;
using namespace std;

EIGEN_FUNCS_API MatrixXcd toMatrixXcd(int dim, double mat[])
{
	auto m = mat;
	MatrixXcd result = MatrixXcd::Zero(dim, dim);

	for (int c = 0; c < dim; c++) {
		for (int r = 0; r < dim; r++) {
			result(c, r)._Val[0] = *(m++);
			result(c, r)._Val[1] = *(m++);
		}
	}
	return result;
}
EIGEN_FUNCS_API VectorXcd toVectorXcd(int dim, double vec[])
{
	auto v = vec;
	VectorXcd result = VectorXcd::Zero(dim);
	for (int c = 0; c < dim; c++) {
		//result[c] = complex<double>(vec[c * 2], vec[c * 2 + 1]);
		result[c]._Val[0] = *(v++);
		result[c]._Val[1] = *(v++);
	}
	return result;
}


EIGEN_FUNCS_API void toDoubleArray(int dim, MatrixXcd mat, double* result)
{
	for (int c = 0; c < dim; c++) {
		for (int r = 0; r < dim; r++) {
			result[c * dim * 2 + r * 2] = mat(c, r)._Val[0];
			result[c * dim * 2 + r * 2 + 1] = mat(c, r)._Val[1];
		}
	}
}

EIGEN_FUNCS_API void toDoubleArray(int dim, VectorXcd vec, double* result)
{
	for (int c = 0; c < dim; c++) {
		result[c * 2] = vec[c]._Val[0];
		result[c * 2 + 1] = vec[c]._Val[1];
	}
}

const std::complex<double> two_pi_i = complex<double>(0, 2 * 3.141592653589793238462643383279);


extern "C" {
	/*
	EIGEN_FUNCS_API void _InverseMat_FullPivLU(int dim, float a[], float ans[]) {
		Eigen::MatrixXf mat = Eigen::MatrixXf::Zero(dim, dim);

		int count = 0;
		for (int c = 0; c < dim; c++) {
			for (int r = 0; r < dim; r++) {
				mat(c, r) = a[count];
				count++;
			}
		}

		Eigen::FullPivLU< Eigen::MatrixXf > lu(mat);
		Eigen::MatrixXf InvMat = mat.inverse();

		count = 0;
		for (int c = 0; c < dim; c++) {
			for (int r = 0; r < dim; r++) {
				ans[count] = InvMat(c, r);
				count++;
			}
		}
	}
	*/

	//複素非対称行列の逆行列を求める
	EIGEN_FUNCS_API void _Inverse(int dim, double mat[], double inverse[])
	{
		//double mat[] をMatrixXcdに変換
		MatrixXcd _mat = toMatrixXcd(dim, mat);
		

		//逆行列を求める
		MatrixXcd _mat_inverse = _mat.inverse();
		
		//逆行列を、double[]に変換
		toDoubleArray(dim, _mat_inverse, inverse);
	}


	//複素非対称行列の固有値、固有ベクトルを求める
	EIGEN_FUNCS_API void _EigenSolver(int dim, double mat[], double eigenValues[], double eigenVectors[])
	{
		//固有値、固有ベクトルを求める
		ComplexEigenSolver<MatrixXcd> solver;
		solver.compute(toMatrixXcd(dim, mat));
		VectorXcd values = solver.eigenvalues();
		MatrixXcd vectors = solver.eigenvectors();
		
		//固有値、固有ベクトルをdouble[]に変換
		toDoubleArray(dim, values, eigenValues);
		toDoubleArray(dim, vectors, eigenVectors);
	}

	//CBEDソルバー
	EIGEN_FUNCS_API void _CBEDSolver(int dim, double potential[], double psi0[], int tDim, double thickness[], double coeff, double result[])
	{
		ComplexEigenSolver<MatrixXcd> solver;
		solver.compute(toMatrixXcd(dim, potential));
		VectorXcd values = solver.eigenvalues();
		MatrixXcd vectors = solver.eigenvectors();

		VectorXcd alpha = vectors.inverse() * toVectorXcd(dim, psi0);

		VectorXcd gammma_alpha = VectorXcd::Zero(dim);

		auto r = &result[0];
		for (int t = 0; t < tDim; ++t)
		{
			const auto coeff2 = two_pi_i * thickness[t] * coeff;
			for (int g = 0; g < dim; ++g) {
				gammma_alpha[g] = exp(values[g] * coeff2) * alpha[g];
			}
			VectorXcd temp = vectors * gammma_alpha;
			for (int g = 0; g < dim; g++) {
				*(r++) = temp[g]._Val[0];
				*(r++) = temp[g]._Val[1];

			}
		}
	
	}

} // extern "C"