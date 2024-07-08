namespace Task3
{
    public static class EnumerableExtension
    {
        /// <summary>
        /// <para> Отсчитать несколько элементов с конца </para>
        /// <example> new[] {1,2,3,4}.EnumerateFromTail(2) = (1, ), (2, ), (3, 1), (4, 0)</example>
        /// </summary> 
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable"></param>
        /// <param name="tailLength">Сколько элеметнов отсчитать с конца  (у последнего элемента tail = 0)</param>
        /// <returns></returns>
        public static IEnumerable<(T item, int? tail)> EnumerateFromTail<T>(this IEnumerable<T> enumerable, int? tailLength)
        {
            var reverseEnum = enumerable.Reverse().ToList(); // Преобразуем для удобной работы
            List<(T, int?)> values = [];
            var length = reverseEnum.Count();
            for (int i = 0; i < length; i++)
            {
                if (i < tailLength)
                    values.Insert(0, (reverseEnum[i], i));
                else
                    values.Insert(0, (reverseEnum[i], null));
            }
            return values;
        }
    }
}
