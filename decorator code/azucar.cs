public class azucar : agregadodecorator
{
    public azucar (bebidacomponent bebida) : base(bebida){ }
    public override double costo => _bebida.costo +  0.5;
    public override string descripcion => string.Format($"{_bebida.descripcion}, Azucar");
}