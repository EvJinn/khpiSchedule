namespace khpiScheduleApi.Helpers
{
    public static class TupleEnumToTupleStringHelper
    {
        public static Tuple<string, string>[]? Convert<T>(Tuple<T, string>[] tuple) where T : System.Enum
        {
            if (tuple == null) return null;

            List<Tuple<string, string>> listTuples = new();

            foreach (var t in tuple)
                listTuples.Add(Tuple.Create(t.Item1.ToString(), t.Item2));

            return listTuples.ToArray();
        }
    }
}
