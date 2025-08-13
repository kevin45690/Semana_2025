namespace progra_3
{
    public static class utileriaGenerica
    {
        public static T Echo<T>(T valor)
        {
            return valor;
        }
        public static bool Esigual<T>(T primerValor, T segundoValor)
        {
            return EqualityComparer<T>.Default.Equals(primerValor, segundoValor);
        }
        public static T Max<T>(T primerValor, T segundoValor) where T : IComparable<T>
        {
            return primerValor.CompareTo(segundoValor)
                >= 0 ? primerValor : segundoValor;


        }
        public static List<T> Repetir<T>(T valor, int Repetir) 
        {
                var list = new List<T>();
            for (int i = 0; i < Repetir; i++)
                list.Add(valor);
            return list;

        }    
    }
}   

