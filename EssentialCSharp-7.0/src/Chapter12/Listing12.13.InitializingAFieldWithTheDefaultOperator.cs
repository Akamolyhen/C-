namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_13
{
    using Listing12_08;

    public struct Pair<T> : IPair<T>
    {
        public Pair(T first)
        {
            First = first;
            Second = default(T);
        }

        public Pair(T first, T second)
        {
            First = first;
            Second = second;
        }

        public T First { get; set; }
        public T Second { get; set; }

    }
}
