
public class edulcorante: agregadodecorator
{
    public edulcorante(bebidacomponent bebida) : base(bebida){}
    public override double costo => _bebida.costo +1;
    public override string descripcion =>string.Format($"{_bebida.descripcion},  edulcorante ");
}
