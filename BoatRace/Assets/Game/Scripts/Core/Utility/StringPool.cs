using System;
using System.Collections.Generic;

namespace BoatRace.Core.Utility
{
    public static class StringPool
    {
        // private const int MaxSize = 1024;
        // private const int MaxQueueSize = 8;
        public static Dictionary<int, Queue<string>> map = new Dictionary<int, Queue<string>>();

        public static void PreAlloc(int size, int count)
        {
            if (size > 1024 || size <= 0)
                return;
            count = Math.Max(8, count);
            Queue<string> stringQueue1 = (Queue<string>) null;
            if (StringPool.map.TryGetValue(size, out stringQueue1)) {
                for (int count1 = stringQueue1.Count; count1 < count; ++count1)
                    stringQueue1.Enqueue(new string('Ì', size));
            }
            else {
                Queue<string> stringQueue2 = new Queue<string>();
                StringPool.map[size] = stringQueue2;
                for (int index = 0; index < count; ++index)
                    stringQueue2.Enqueue(new string('Ì', size));
            }
        }

        public static string Alloc(int size)
        {
            if (size == 0)
                return string.Empty;
            if (size >= 1024)
                return new string('Ì', size);
            Queue<string> stringQueue1 = (Queue<string>) null;
            if (StringPool.map.TryGetValue(size, out stringQueue1)) {
                if (stringQueue1.Count > 0)
                    return stringQueue1.Dequeue();
            }
            else {
                Queue<string> stringQueue2 = new Queue<string>();
                StringPool.map[size] = stringQueue2;
            }

            return new string('Ì', size);
        }

        public static void Collect(string str)
        {
            if (string.IsNullOrEmpty(str))
                return;
            int length = str.Length;
            if (length >= 1024 || length <= 0)
                return;
            Queue<string> stringQueue = (Queue<string>) null;
            if (!StringPool.map.TryGetValue(str.Length, out stringQueue)) {
                stringQueue = new Queue<string>();
                StringPool.map[length] = stringQueue;
            }

            if (stringQueue.Count > 8)
                return;
            stringQueue.Enqueue(str);
        }
    }
}