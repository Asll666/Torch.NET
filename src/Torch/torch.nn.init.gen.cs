// Code generated by CodeMinion: https://github.com/SciSharp/CodeMinion

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using Numpy;
using Numpy.Models;

namespace Torch
{
    public static partial class torch
    {
        
        public static partial class nn {
            public static partial class init {
                /// <summary>
                ///	Return the recommended gain value for the given nonlinearity function.<br></br>
                ///	
                ///	The values are as follows:
                ///	
                ///	nonlinearity
                ///	gain
                ///	
                ///	Linear / Identity
                ///	\(1\)
                ///	
                ///	Conv{1,2,3}D
                ///	\(1\)
                ///	
                ///	Sigmoid
                ///	\(1\)
                ///	
                ///	Tanh
                ///	\(\frac{5}{3}\)
                ///	
                ///	ReLU
                ///	\(\sqrt{2}\)
                ///	
                ///	Leaky Relu
                ///	\(\sqrt{\frac{2}{1 + \text{negative\_slope}^2}}\)
                /// </summary>
                /// <param name="nonlinearity">
                ///	the non-linear function (nn.functional name)
                /// </param>
                /// <param name="param">
                ///	optional parameter for the non-linear function
                /// </param>
                public static void calculate_gain(string nonlinearity, double? param = null)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var init = nn.GetAttr("init");
                    var __self__=init;
                    var pyargs=ToTuple(new object[]
                    {
                        nonlinearity,
                    });
                    var kwargs=new PyDict();
                    if (param!=null) kwargs["param"]=ToPython(param);
                    dynamic py = __self__.InvokeMethod("calculate_gain", pyargs, kwargs);
                }
            }
        }
        
        public static partial class nn {
            public static partial class init {
                /// <summary>
                ///	Fills the input Tensor with values drawn from the uniform
                ///	distribution \(\mathcal{U}(a, b)\).
                /// </summary>
                /// <param name="tensor">
                ///	an n-dimensional torch.Tensor
                /// </param>
                /// <param name="a">
                ///	the lower bound of the uniform distribution
                /// </param>
                /// <param name="b">
                ///	the upper bound of the uniform distribution
                /// </param>
                public static void uniform_(Tensor tensor, double a = 0.0, double b = 1.0)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var init = nn.GetAttr("init");
                    var __self__=init;
                    var pyargs=ToTuple(new object[]
                    {
                        tensor,
                    });
                    var kwargs=new PyDict();
                    if (a!=0.0) kwargs["a"]=ToPython(a);
                    if (b!=1.0) kwargs["b"]=ToPython(b);
                    dynamic py = __self__.InvokeMethod("uniform_", pyargs, kwargs);
                }
            }
        }
        
        public static partial class nn {
            public static partial class init {
                /// <summary>
                ///	Fills the input Tensor with values drawn from the normal
                ///	distribution \(\mathcal{N}(\text{mean}, \text{std})\).
                /// </summary>
                /// <param name="tensor">
                ///	an n-dimensional torch.Tensor
                /// </param>
                /// <param name="mean">
                ///	the mean of the normal distribution
                /// </param>
                /// <param name="std">
                ///	the standard deviation of the normal distribution
                /// </param>
                public static void normal_(Tensor tensor, double mean = 0.0, double std = 1.0)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var init = nn.GetAttr("init");
                    var __self__=init;
                    var pyargs=ToTuple(new object[]
                    {
                        tensor,
                    });
                    var kwargs=new PyDict();
                    if (mean!=0.0) kwargs["mean"]=ToPython(mean);
                    if (std!=1.0) kwargs["std"]=ToPython(std);
                    dynamic py = __self__.InvokeMethod("normal_", pyargs, kwargs);
                }
            }
        }
        
        public static partial class nn {
            public static partial class init {
                /// <summary>
                ///	Fills the input Tensor with the value \(\text{val}\).
                /// </summary>
                /// <param name="tensor">
                ///	an n-dimensional torch.Tensor
                /// </param>
                /// <param name="val">
                ///	the value to fill the tensor with
                /// </param>
                public static void constant_<T>(Tensor tensor, T val)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var init = nn.GetAttr("init");
                    var __self__=init;
                    var pyargs=ToTuple(new object[]
                    {
                        tensor,
                        val,
                    });
                    var kwargs=new PyDict();
                    dynamic py = __self__.InvokeMethod("constant_", pyargs, kwargs);
                }
            }
        }
        
        public static partial class nn {
            public static partial class init {
                /// <summary>
                ///	Fills the 2-dimensional input Tensor with the identity
                ///	matrix.<br></br>
                ///	 Preserves the identity of the inputs in Linear layers, where as
                ///	many inputs are preserved as possible.
                /// </summary>
                public static void eye_(Tensor tensor)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var init = nn.GetAttr("init");
                    var __self__=init;
                    var pyargs=ToTuple(new object[]
                    {
                        tensor,
                    });
                    var kwargs=new PyDict();
                    dynamic py = __self__.InvokeMethod("eye_", pyargs, kwargs);
                }
            }
        }
        
        public static partial class nn {
            public static partial class init {
                /// <summary>
                ///	Fills the {3, 4, 5}-dimensional input Tensor with the Dirac
                ///	delta function.<br></br>
                ///	 Preserves the identity of the inputs in Convolutional
                ///	layers, where as many input channels are preserved as possible.
                /// </summary>
                public static void dirac_(Tensor tensor)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var init = nn.GetAttr("init");
                    var __self__=init;
                    var pyargs=ToTuple(new object[]
                    {
                        tensor,
                    });
                    var kwargs=new PyDict();
                    dynamic py = __self__.InvokeMethod("dirac_", pyargs, kwargs);
                }
            }
        }
        
        public static partial class nn {
            public static partial class init {
                /// <summary>
                ///	Fills the input Tensor with values according to the method
                ///	described in Understanding the difficulty of training deep feedforward
                ///	neural networks - Glorot, X.<br></br>
                ///	 &amp; Bengio, Y.<br></br>
                ///	 (2010), using a uniform
                ///	distribution.<br></br>
                ///	 The resulting tensor will have values sampled from
                ///	\(\mathcal{U}(-a, a)\) where
                ///	
                ///	\[a = \text{gain} \times \sqrt{\frac{6}{\text{fan\_in} + \text{fan\_out}}}
                ///	
                ///	\]
                ///	
                ///	Also known as Glorot initialization.
                /// </summary>
                /// <param name="tensor">
                ///	an n-dimensional torch.Tensor
                /// </param>
                /// <param name="gain">
                ///	an optional scaling factor
                /// </param>
                public static void xavier_uniform_(Tensor tensor, double gain = 1.0)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var init = nn.GetAttr("init");
                    var __self__=init;
                    var pyargs=ToTuple(new object[]
                    {
                        tensor,
                    });
                    var kwargs=new PyDict();
                    if (gain!=1.0) kwargs["gain"]=ToPython(gain);
                    dynamic py = __self__.InvokeMethod("xavier_uniform_", pyargs, kwargs);
                }
            }
        }
        
        public static partial class nn {
            public static partial class init {
                /// <summary>
                ///	Fills the input Tensor with values according to the method
                ///	described in Understanding the difficulty of training deep feedforward
                ///	neural networks - Glorot, X.<br></br>
                ///	 &amp; Bengio, Y.<br></br>
                ///	 (2010), using a normal
                ///	distribution.<br></br>
                ///	 The resulting tensor will have values sampled from
                ///	\(\mathcal{N}(0, \text{std})\) where
                ///	
                ///	\[\text{std} = \text{gain} \times \sqrt{\frac{2}{\text{fan\_in} + \text{fan\_out}}}
                ///	
                ///	\]
                ///	
                ///	Also known as Glorot initialization.
                /// </summary>
                /// <param name="tensor">
                ///	an n-dimensional torch.Tensor
                /// </param>
                /// <param name="gain">
                ///	an optional scaling factor
                /// </param>
                public static void xavier_normal_(Tensor tensor, double gain = 1.0)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var init = nn.GetAttr("init");
                    var __self__=init;
                    var pyargs=ToTuple(new object[]
                    {
                        tensor,
                    });
                    var kwargs=new PyDict();
                    if (gain!=1.0) kwargs["gain"]=ToPython(gain);
                    dynamic py = __self__.InvokeMethod("xavier_normal_", pyargs, kwargs);
                }
            }
        }
        
        public static partial class nn {
            public static partial class init {
                /// <summary>
                ///	Fills the input Tensor with values according to the method
                ///	described in Delving deep into rectifiers: Surpassing human-level
                ///	performance on ImageNet classification - He, K.<br></br>
                ///	 et al.<br></br>
                ///	 (2015), using a
                ///	uniform distribution.<br></br>
                ///	 The resulting tensor will have values sampled from
                ///	\(\mathcal{U}(-\text{bound}, \text{bound})\) where
                ///	
                ///	\[\text{bound} = \sqrt{\frac{6}{(1 + a^2) \times \text{fan\_in}}}
                ///	
                ///	\]
                ///	
                ///	Also known as He initialization.
                /// </summary>
                /// <param name="tensor">
                ///	an n-dimensional torch.Tensor
                /// </param>
                /// <param name="a">
                ///	the negative slope of the rectifier used after this layer (0 for ReLU
                ///	by default)
                /// </param>
                /// <param name="mode">
                ///	either 'fan_in' (default) or 'fan_out'. Choosing 'fan_in'
                ///	preserves the magnitude of the variance of the weights in the
                ///	forward pass.<br></br>
                ///	Choosing 'fan_out' preserves the magnitudes in the
                ///	backwards pass.
                /// </param>
                /// <param name="nonlinearity">
                ///	the non-linear function (nn.functional name),
                ///	recommended to use only with 'relu' or 'leaky_relu' (default).
                /// </param>
                public static void kaiming_uniform_(Tensor tensor, int a = 0, string mode = "fan_in", string nonlinearity = "leaky_relu")
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var init = nn.GetAttr("init");
                    var __self__=init;
                    var pyargs=ToTuple(new object[]
                    {
                        tensor,
                    });
                    var kwargs=new PyDict();
                    if (a!=0) kwargs["a"]=ToPython(a);
                    if (mode!="fan_in") kwargs["mode"]=ToPython(mode);
                    if (nonlinearity!="leaky_relu") kwargs["nonlinearity"]=ToPython(nonlinearity);
                    dynamic py = __self__.InvokeMethod("kaiming_uniform_", pyargs, kwargs);
                }
            }
        }
        
        public static partial class nn {
            public static partial class init {
                /// <summary>
                ///	Fills the input Tensor with values according to the method
                ///	described in Delving deep into rectifiers: Surpassing human-level
                ///	performance on ImageNet classification - He, K.<br></br>
                ///	 et al.<br></br>
                ///	 (2015), using a
                ///	normal distribution.<br></br>
                ///	 The resulting tensor will have values sampled from
                ///	\(\mathcal{N}(0, \text{std})\) where
                ///	
                ///	\[\text{std} = \sqrt{\frac{2}{(1 + a^2) \times \text{fan\_in}}}
                ///	
                ///	\]
                ///	
                ///	Also known as He initialization.
                /// </summary>
                /// <param name="tensor">
                ///	an n-dimensional torch.Tensor
                /// </param>
                /// <param name="a">
                ///	the negative slope of the rectifier used after this layer (0 for ReLU
                ///	by default)
                /// </param>
                /// <param name="mode">
                ///	either 'fan_in' (default) or 'fan_out'. Choosing 'fan_in'
                ///	preserves the magnitude of the variance of the weights in the
                ///	forward pass.<br></br>
                ///	Choosing 'fan_out' preserves the magnitudes in the
                ///	backwards pass.
                /// </param>
                /// <param name="nonlinearity">
                ///	the non-linear function (nn.functional name),
                ///	recommended to use only with 'relu' or 'leaky_relu' (default).
                /// </param>
                public static void kaiming_normal_(Tensor tensor, int a = 0, string mode = "fan_in", string nonlinearity = "leaky_relu")
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var init = nn.GetAttr("init");
                    var __self__=init;
                    var pyargs=ToTuple(new object[]
                    {
                        tensor,
                    });
                    var kwargs=new PyDict();
                    if (a!=0) kwargs["a"]=ToPython(a);
                    if (mode!="fan_in") kwargs["mode"]=ToPython(mode);
                    if (nonlinearity!="leaky_relu") kwargs["nonlinearity"]=ToPython(nonlinearity);
                    dynamic py = __self__.InvokeMethod("kaiming_normal_", pyargs, kwargs);
                }
            }
        }
        
        public static partial class nn {
            public static partial class init {
                /// <summary>
                ///	Fills the input Tensor with a (semi) orthogonal matrix, as
                ///	described in Exact solutions to the nonlinear dynamics of learning in deep
                ///	linear neural networks - Saxe, A.<br></br>
                ///	 et al.<br></br>
                ///	 (2013).<br></br>
                ///	 The input tensor must have
                ///	at least 2 dimensions, and for tensors with more than 2 dimensions the
                ///	trailing dimensions are flattened.
                /// </summary>
                /// <param name="tensor">
                ///	an n-dimensional torch.Tensor, where \(n \geq 2\)
                /// </param>
                /// <param name="gain">
                ///	optional scaling factor
                /// </param>
                public static void orthogonal_(Tensor tensor, int gain = 1)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var init = nn.GetAttr("init");
                    var __self__=init;
                    var pyargs=ToTuple(new object[]
                    {
                        tensor,
                    });
                    var kwargs=new PyDict();
                    if (gain!=1) kwargs["gain"]=ToPython(gain);
                    dynamic py = __self__.InvokeMethod("orthogonal_", pyargs, kwargs);
                }
            }
        }
        
        public static partial class nn {
            public static partial class init {
                /// <summary>
                ///	Fills the 2D input Tensor as a sparse matrix, where the
                ///	non-zero elements will be drawn from the normal distribution
                ///	\(\mathcal{N}(0, 0.01)\), as described in Deep learning via
                ///	Hessian-free optimization - Martens, J.<br></br>
                ///	 (2010).
                /// </summary>
                /// <param name="tensor">
                ///	an n-dimensional torch.Tensor
                /// </param>
                /// <param name="sparsity">
                ///	The fraction of elements in each column to be set to zero
                /// </param>
                /// <param name="std">
                ///	the standard deviation of the normal distribution used to generate
                ///	the non-zero values
                /// </param>
                public static void sparse_(Tensor tensor, double sparsity, double std = 0.01)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var init = nn.GetAttr("init");
                    var __self__=init;
                    var pyargs=ToTuple(new object[]
                    {
                        tensor,
                        sparsity,
                    });
                    var kwargs=new PyDict();
                    if (std!=0.01) kwargs["std"]=ToPython(std);
                    dynamic py = __self__.InvokeMethod("sparse_", pyargs, kwargs);
                }
            }
        }
        
        
    }
}