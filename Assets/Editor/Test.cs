using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class Test {

	[Test]
	public void TestSimplePasses()
	{

		var node = default(ILinkNode<string>);

		ICompute<string, int> c = default(ICompute<string, int>);
		ICompute<int, Object> c2 = default(ICompute<int, Object>);
		ICompute<Object, byte> c3 = default(ICompute<Object, byte>);
		
		var cancel = node.Append(c).Append(c2).Append(c3).Run();
		cancel.Dispose();
		
	}

}
