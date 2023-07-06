class Mod2
{
    enum Figure
    {
        Triangle = 1,
        Square,
        Circle
    }
    struct Figure_struct
    {
        private Figure type;
        private float p, s;
        public Figure_struct(Figure a, int p, int s) : this()
        {
            this.type = Figure.Triangle;
            this.p = p;
            this.s = s;
        }
        public Figure get_type()
        {
            return type;
        }
        public static void swap(int a, out int b)
        {
            b = a;
        }
        public static void func1(params int[] list)
        {
            Console.WriteLine(list[0]);
            Console.Write(list[1]);
        }
        static void Main(String[] args)
        {
            Figure fig = Figure.Circle;
            Figure_struct exmple_strct = new Figure_struct
                (
                Figure.Circle,
                100,
                7
                );
            int a = 12, b;
            swap(a, out b);
            func1(1, 2, 3, 4, 5);
        }
    }
}
