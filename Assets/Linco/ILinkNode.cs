using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInnerLink<T1, T2>
{
	
}

public interface ICompute<TInput, TOutput>
{
	TOutput Compute(TInput input);
}

public interface ILinkNode<T>
{
	ILinkNode<TOutput> Append<TOutput>(ICompute<T, TOutput> compute);
	IDisposable Run();
}