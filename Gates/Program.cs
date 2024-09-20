// See https://aka.ms/new-console-template for more information

using Gates;

bool a = true;
bool b = true;
bool c = true;

CompuertaNOT NegA = new CompuertaNOT("not-a", a);
bool notA = NegA.Calcular();
CompuertaNOT NegB = new CompuertaNOT("not-a", b);
bool notB = NegA.Calcular();

CompuertaAND firstAND = new CompuertaAND("First And");
firstAND.agregarEntrada(a);
firstAND.agregarEntrada(b);
bool resultadoAND = firstAND.Calcular();
CompuertaAND secondAND = new CompuertaAND("Second And");
secondAND.agregarEntrada(notA);
secondAND.agregarEntrada(notB);
bool resultadoNotAND = secondAND.Calcular();

CompuertaOR firstOR = new CompuertaOR("FirstOR");
firstOR.agregarEntrada(resultadoAND);
firstOR.agregarEntrada(resultadoNotAND);
bool resultadoOR = firstOR.Calcular();

CompuertaAND thirdAND = new CompuertaAND("Third AND");
thirdAND.agregarEntrada(resultadoOR);
thirdAND.agregarEntrada(c);
Console.WriteLine(thirdAND.Calcular());