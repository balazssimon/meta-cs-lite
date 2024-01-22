namespace MetaModelTests;

using MetaDslx.CodeAnalysis.Symbols;

metamodel TestModel;

class Husband
{
    Wife Wife opposite Wife.Husband;
}

class Wife
{
    Husband Husband opposite Husband.Wife;
}
