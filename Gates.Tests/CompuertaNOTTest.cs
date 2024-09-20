using Gates;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gates.Tests;

[TestClass]
[TestSubject(typeof(CompuertaNOT))]
public class CompuertaNOTTest
{

    [TestMethod]
    public void EvaluarTest()
    {
        CompuertaNOT not = new CompuertaNOT("not-1", true);
        bool resultadoEsperado = not.Calcular();
        
        Assert.AreEqual(resultadoEsperado, false);
    }
    
    [TestMethod]
    public void EvaluarTestWithTrue()
    {
        CompuertaNOT not = new CompuertaNOT("not-1", false);
        bool resultadoEsperado = not.Calcular();
        
        Assert.AreEqual(resultadoEsperado, true);
    }
}