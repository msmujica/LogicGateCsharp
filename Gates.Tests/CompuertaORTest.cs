using Gates;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gates.Tests;

[TestClass]
[TestSubject(typeof(CompuertaOR))]
public class CompuertaORTest
{

    [TestMethod]
    public void EvaluarTest()
    {
        CompuertaOR or = new CompuertaOR("or-1");
        
        or.agregarEntrada(true);
        or.agregarEntrada(true);
        
        Assert.AreEqual(true, or.Calcular());
    }
    
    [TestMethod]
    public void EvaluarTestWithFalse()
    {
        CompuertaOR or = new CompuertaOR("or-1");
        
        or.agregarEntrada(true);
        or.agregarEntrada(false);
        
        Assert.AreEqual(true, or.Calcular());
    }

}