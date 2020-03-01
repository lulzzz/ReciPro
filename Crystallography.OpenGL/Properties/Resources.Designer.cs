﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Crystallography.OpenGL.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Crystallography.OpenGL.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   #version 430 core
        ///
        /////#pragma optionNV(ifcvt none)
        /////#pragma optionNV(inline all)
        /////#pragma optionNV(strict on)
        /////#pragma optionNV(unroll all)
        ///
        ///layout(early_fragment_tests) in;
        ///
        ///#define MAX_FRAGMENTS 75
        ///
        ///uniform uint MaxNodes;
        ///
        ///// Material properties
        ///uniform float Emission = 0.2;
        ///uniform float Ambient = 0.2;
        ///uniform float Diffuse = 0.7;
        ///uniform float Specular = 0.5;
        ///uniform vec3 SpecularColor = vec3(1.0);
        ///uniform float SpecularPower = 128.0;
        ///uniform vec4 BgColor = vec4(1, 1, 1, 1);
        ///unifo [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string frag {
            get {
                return ResourceManager.GetString("frag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   #version 420 core
        ///
        ///layout(triangles) in;
        ///layout(triangle_strip, max_vertices = 6) out;
        ///
        ///uniform int counter = 0;
        ///
        ///in VertexData
        ///{
        ///	vec3 Normal;//Normal direction
        ///	vec3 Light;//Light direction
        ///	vec3 View;//View direction
        ///	vec3 Color;//Color
        ///} gs_in[];
        ///
        ///out VertexData
        ///{
        ///	vec3 Normal;//Normal direction
        ///	vec3 Light;//Light direction
        ///	vec3 View;//View direction
        ///	vec3 Color;//Color
        ///} gs_out;
        ///
        ///void main(void)
        ///{
        ///	int i;
        ///	for (i = 0; i &lt; gs_in.length(); i++)
        ///	{
        ///		gl_Position = gl_in[i].gl [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string geom {
            get {
                return ResourceManager.GetString("geom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   #version 430 core
        ///
        /////#pragma optionNV(ifcvt none)
        /////#pragma optionNV(inline all)
        /////#pragma optionNV(strict on)
        /////#pragma optionNV(unroll all)
        ///
        ///// Per-vertex inputs
        ///layout(location = 2) in vec4 Position;
        ///layout(location = 3) in vec3 Normal;
        ///layout(location = 4) in vec4 Color;
        ///
        ///uniform mat4 WorldMatrix; //world matrix
        ///uniform mat4 ViewMatrix; // view matrix
        ///uniform mat4 ProjMatrix; // projection matrix
        ///uniform vec3 LightPosition; // Position of light
        ///uniform vec3 EyePosition;// Position of eye [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string vert {
            get {
                return ResourceManager.GetString("vert", resourceCulture);
            }
        }
    }
}
