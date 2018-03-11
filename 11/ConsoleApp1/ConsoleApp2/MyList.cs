namespace ConsoleApp1
{
    interface IMyList<T>
    {
        void Clear();
        void Add(T val);
        int Length {get;}
        bool Contains { get; }
        T this[int index] { get; }



    }


    class MyList<T> : IMyList<T>
    {
        Chain<T> FirstBlock;
        int count;
        bool contains;




        public bool Contains { get { return contains; } }

        public void Clear()
        {
            FirstBlock = new Chain<T>();
            count = 0;
            contains = false;


        }

        public MyList()
        {
            count = 0;
            contains = false;
        }

        public MyList(T first)
        {
            FirstBlock = new Chain<T>();
            FirstBlock.Conteiner = first;
            count = 1;
            contains = true;

        }

        public void Add(T val)
        {
            if (!contains)
            {
                FirstBlock = new Chain<T>();
                FirstBlock.Conteiner = val;
                contains = true;
                count++;

                return;
            }
            Chain<T> tmp = FirstBlock;
            for (int i = 0; i < count - 1; i++)
            {
                tmp = tmp.Next;
            }

            tmp.Next = new Chain<T>();
            tmp.Next.Conteiner = val;
            count++;
        }

        public T this[int index]
        {
            get
            {


                Chain<T> tmp = FirstBlock;
                for (int i = 0; i < index; i++)
                {
                    tmp = tmp.Next;
                }


                return tmp.Conteiner;
            }
            private set { }
        }

        public int Length { get { return count; } }

    }


    class Chain<T>
    {
        public T Conteiner { get; set; }
        public Chain<T> Next { get; set; }

    }
}
