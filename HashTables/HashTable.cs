using System;
using System.Collections.Generic;
namespace Algorithms_DS.HashTables
{
    public class HashTable
    {
        private class Entry{
            public int Key;
            public string  Value;
            public Entry(int key, string value)
            {
                this.Key = key;
                this.Value = value;
            }
        }

        private LinkedList<Entry>[] entries = new LinkedList<Entry>[5];

        public void Put(int key, string value)
        {
            var entry = GetEntry(key);
            if(entry != null){
                entry.Value = value;
                return;
            }

            GetOrCreateBucket(key).AddLast(new Entry(key,value));
        }

        public string Get(int key)
        {
            var index = Hash(key);
            var bucket = entries[index];
            return GetEntry(key) != null ? GetEntry(key).Value: null;
        }

        public void Remove(int key)
        {
            var item = GetEntry(key);
            if(item != null)
               GetBucket(key).Remove(item);
            
            throw new InvalidOperationException();
        }

        private int Hash(int key)
        {
            var absKey = Math.Abs(key);
            return absKey % entries.Length;
        }

        private LinkedList<Entry> GetOrCreateBucket(int key)
        {
            var index = Hash(key);
            var bucket = entries[index];
            if(bucket == null)
             entries[index] = new LinkedList<Entry>();
            return bucket;
        }
        private LinkedList<Entry> GetBucket(int key)
        {
            return entries[key];
        }

        private Entry GetEntry(int key)
        {
            var index = Hash(key);
            var bucket = entries[index];
            if(bucket != null){
            foreach (var item in bucket)
            {
                if(item.Key == key)
                return item;
            }
            }
            return null;
        }
    }
}