using System;
namespace KthToLast
{
	public static class LinkedListExtensions
	{
		public static T KthToLastSinglyLinked<T>(this LinkedList<T> linkedList, int k)
		{
			return default;
		}

        public static T KthToLastDoublyLinked<T>(this LinkedList<T> linkedList, int k)
        {
			if ( k > linkedList.Count || k < 0 )
			{
				throw new IndexOutOfRangeException();
			}

			LinkedListNode<T> currentNode = linkedList.Last;

			for( int i=0; i < k ; i++ )
			{
				currentNode = currentNode.Previous;
            }

            return currentNode.Value;

        }
    }
}

