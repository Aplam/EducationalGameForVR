using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Heighttest
    {
		[Test]
		public void ResizeUpTest()
		{
			float currentHeight = 1.0f;
			currentHeight = currentHeight + 0.1f;
			Vector3 height = new Vector3(1, currentHeight, 1);
			Assert.AreEqual(1.1f, height.y);

		}

		[Test]
		public void ResizeDownTest()
		{

			float currentHeight = 1.0f;
			currentHeight = currentHeight - 0.1f;
			Vector3 height = new Vector3(1, currentHeight, 1);
			Assert.AreEqual(0.9f,  height.y);

		}
	}
}
