
public abstract class agregadodecorator : bebidacomponent
{
    public  bebidacomponent _bebida;
    public agregadodecorator(bebidacomponent bebida)
    {
        _bebida = bebida;
    }
}
