using Gates;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gates.Tests;

[TestClass]
[TestSubject(typeof(CompuertaAND))]
public class CompuertaANDTest
{

    [TestMethod]
    public void EvaluarTest()
    {
        CompuertaAND and = new CompuertaAND("and-1");
        
        and.agregarEntrada(true);
        and.agregarEntrada(true);

        Assert.AreEqual(true, and.Calcular());
    }
    
    [TestMethod]
    public void EvaluarTestWithFalse()
    {
        CompuertaAND and = new CompuertaAND("and-1");
        
        and.agregarEntrada(true);
        and.agregarEntrada(false);

        Assert.AreEqual(false, and.Calcular());
    }

    [TestMethod]
    public void EvaluarTestWithDoubleFalse()
    {
        CompuertaAND and = new CompuertaAND("and-1");
        
        and.agregarEntrada(false);
        and.agregarEntrada(false);

        Assert.AreEqual(false, and.Calcular());
    }

}