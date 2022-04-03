namespace LinkedList
{
    public class LList
    {
        private Node _root;

        private Node _tail;

        public int this[int index]
        {
            get
            {
                Node crnt = _root;
                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }

                return crnt.Value;
            }

            set
            {
                Node crnt = _root;
                for (int i = 1; i <= index; i++)
                { 
                    crnt=crnt.Next;
                }
                crnt.Value = value;
            }
        }

        public int Length
        {
            get
            {
                int count = 0;
                Node crnt = _root;

                while (crnt != null)
                {
                    crnt = crnt.Next;
                    count++;
                }

                return count;
            }
            private set
            {
            }
        }

        public LList()
        {
            _root = null;

            _tail = null;
        }

        public LList(int value)
        {
            _root = new Node(value);
            _tail = _root;
        }
        public LList(int[] values)
        {
            if (values.Length == 0)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                _root = new Node(values[0]);
                _tail = _root;

                for (int i = 1; i < values.Length; i++)
                {
                    Add(values[i]);
                }
            }
        }

        public void Add(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                _tail.Next = new Node(value);
                _tail = _tail.Next;
            }
            Length++;
        }

        public void AddFirst(int value)
        {
            Node crnt = new Node(value);
            crnt.Next = _root;
            _root = crnt;

            Length++;

        }

        public void AddByIndex(int value, int index)
        {
            if (Length == 0)
            {
                throw new Exception("The list is empty");
            }
            if (index < 0 || index > Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 0)
            {
                AddFirst(value);
            }
            else
            {
                Node crnt = _root;
                for (int i = 1; i < index; i++)
                {
                    crnt = crnt.Next;
                }
                Node node = new Node(value);
                node.Next = crnt.Next;
                crnt.Next = node;
            }

            Length++;
            
        }

        public void DeleteLast()
        {
            if(Length == 0)
            {
                throw new Exception("The list is empty");
            }
            Node crnt = _root;
            for(int i=1; i<Length-1; i++)
            {
                crnt= crnt.Next;
            }
            crnt.Next = null;
            Length--;
        }

        public void DeleteFirst()
        {
            if (Length == 0)
            {
                throw new Exception("The list is empty");
            }
            Node crnt = _root.Next;
            _root=crnt;

            Length--;

        }

        public void DeleteByIndex(int index)
        {
            if (Length == 0)
            {
                throw new Exception("The list is empty");
            }
            else if(index < 0 || index > Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 0)
            {
                DeleteFirst();
            }
            else
            {
                Node crnt = _root;
                for (int i = 1; i < index; i++)
                {
                    crnt = crnt.Next;
                }
                crnt.Next = crnt.Next.Next;
            }
            
        }

        public void DeleteFewLastElements(int amount)
        {
            if (Length == 0)
            {
                throw new Exception("The List is empty");
            }
            else if(amount>Length || amount<0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int tmpLength=Length-amount;
            Node crnt = _root;
            for(int i = 1; i <tmpLength; i++)
            {
                crnt = crnt.Next;
            }
            crnt.Next = null;
            Length -= amount;

        }

        public void DeleteFewFirstElements(int amount)
        {
            if (Length == 0)
            {
                throw new Exception("The List is empty");
            }
            else if (amount > Length || amount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (amount != 0)
            {
                Node crnt = _root;
                for (int i = 1; i < amount; i++)
                {
                    crnt = crnt.Next;
                }
                _root = crnt.Next;
            } 
            Length -= amount;
        }
        
        public void DeleteFewElementsByIndex(int index, int amount)
        {
            if (Length == 0)
            {
                throw new Exception("The List is empty");
            }
            else if (amount > Length || amount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if(index<0 || index > Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
            if (amount != 0)
            {
                Node crnt = _root;
                for (int i = 1; i < index; i++)
                {
                    crnt = crnt.Next;
                }
                int counterOfElements = Length - amount - index;
                    if (counterOfElements > 0)
                    {
                    
                    Node crntAfterDelete = crnt.Next;
                    for (int i = index; i <= amount; i++)
                    {
                        crntAfterDelete = crntAfterDelete.Next;
                    }
                    crnt.Next = crntAfterDelete.Next;
                    }
                    else
                    {
                    crnt.Next = null;
                    }
                
            }
            Length -= amount;
        }

        public int FindFirstIndexByValue(int value)
        {
            if (Length == 0)
            {
                throw new Exception("The list is empty");
            }
            int index = 0;
            Node crnt = _root;
            while(crnt!= null)
            {
                if (crnt.Value == value)
                {
                    return index;
                }
                crnt = crnt.Next;
                index++;
            }
            return -1;
        }

        public int FindMaxValue()
        {
            if(Length == 0)
            {
                throw new Exception("The list is empty");
            }

            int maxValue = _root.Value;
            Node crnt=_root;
            while (crnt != null)
            {
                if (maxValue < crnt.Value)
                {
                    maxValue=crnt.Value;
                }
                crnt=crnt.Next;
            }
            return maxValue;
        }

        public int FindMinValue()
        {

            if (Length == 0)
            {
                throw new Exception("The list is empty");
            }
            int minValue=_root.Value;
            Node crnt = _root;
            while (crnt != null)
            {
                if(minValue > crnt.Value)
                {
                    minValue=crnt.Value;
                }
                crnt = crnt.Next;
            }
            return minValue;
        }

        public int FindIndexOfMinValue()
        {
            if( Length == 0)
            {
                throw new Exception("The list is empty");
            }
            int index = 0;
            int minValue = _root.Value;
            Node crnt = _root;
            while (crnt != null)
            {
                if (minValue > crnt.Value)
                {
                    minValue = crnt.Value;
                }
                crnt=crnt.Next;
            }
            crnt = _root;
            while (minValue != crnt.Value)
            {
                crnt = crnt.Next;
                index++;
            }
            return index;
        }

        public int FindIndexOfMaxValue()
        {
            if (Length == 0)
            {
                throw new Exception("The list is empty");
            }
            int index = 0;
            int maxValue = _root.Value;
            Node crnt = _root;
            while (crnt != null)
            {
                if (maxValue < crnt.Value)
                {
                    maxValue = crnt.Value;
                }
                crnt = crnt.Next;
            }
            crnt = _root;
            while (maxValue != crnt.Value)
            {
                crnt = crnt.Next;
                index++;
            }
            return index;
        }

        public int DeleteFirstByValue(int value)
        {
            int index = 0;
            Node crnt = _root;
            while(crnt != null)
            {
                if (value == crnt.Value)
                {
                    break;
                }
                crnt = crnt.Next;
                index++;
            }
            DeleteByIndex(index);

            return index;

        }

        public int DeleteEveryElementByValue(int value)
        {
            if (Length == 0)
            {
                throw new Exception("The list is empty");
            }
            int count = 0;
            int index = 0;
            Node crnt = _root;
            while (crnt!=null)
            {
                if (crnt.Value == value)
                {
                    if (index == 0)
                    {
                        _root = crnt.Next;
                        count++;
                        index--;
                    }
                    else if (crnt.Value == value)
                    {
                        Node prev = GetNodeByIndex(index - 1);
                        prev.Next = crnt.Next;
                        count++;
                        index--;
                    }
                }
                crnt = crnt.Next;
                index++;
            }
            return count;
        }

        public void Reverse()
        {
            if (Length == 0)
            {
                throw new Exception("The list is empty");
            }
            Node oldRoot = _root;
            while(oldRoot.Next != null)
            {
                Node tmp = oldRoot.Next;
                oldRoot.Next = oldRoot.Next.Next;
                tmp.Next = _root;
                _root = tmp;
            }
            _tail = oldRoot;
        }
        public override string ToString()
        {
            string s = "";
            Node crnt = _root;

            while (crnt != null)
            {
                s += $"{crnt.Value} ";
                crnt = crnt.Next;
            }

            return s;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is LList))
            {
                return false;
            }

            LList list = (LList)obj;

            if (list.Length != this.Length)
            {
                return false;
            }

            Node thisCrnt = this._root;
            Node listCrnt = list._root;

            while (thisCrnt != null)
            {
                if (thisCrnt.Value != listCrnt.Value)
                {
                    return false;
                }

                thisCrnt = thisCrnt.Next;
                listCrnt = listCrnt.Next;
            }

            return true;
        }
        private Node GetNodeByIndex(int index)
        {
            Node crnt = _root;
            for (int i = 1; i <= index; i++)
            {
                crnt = crnt.Next;
            }

            return crnt;
        }
    }
}