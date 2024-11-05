using System;
using System.Collections.Generic;

namespace NPuzzleAI
{
    public class State
    {
        public static int Heuristic { get; set; }
        public static int Goal { get; set; }
        public int[] Value { get; set; }
        private readonly int size;
        private readonly int length;
        private int blank;

        // Khởi tạo với kích thước của puzzle
        public State(int m)
        {
            size = m;
            length = size * size;
            Value = new int[length];
            blank = 0;
        }

        // Khởi tạo với trạng thái và kích thước của puzzle
        public State(int[] v, int size)
        {
            Value = v;
            this.size = size;
            length = size * size;
            blank = PosBlank(Value);
        }

        // Khởi tạo trạng thái
        public void Init()
        {
            if (Goal == 1)
            {
                for (int i = 0; i < length; i++)
                {
                    Value[i] = i;
                }
            }
            else
            {
                for (int i = 0; i < length - 1; i++)
                {
                    Value[i] = i + 1;
                }
                Value[length - 1] = 0;
            }
        }

        // Tạo trạng thái đích
        public int[] CreateGoalArray()
        {
            Init();
            return Value;
        }

        // Tạo trạng thái ngẫu nhiên
        public int[] CreateRandomArray()
        {
            Init();
            Random rand = new Random();
            int t = 20 * size;
            int count = 0;
            int a = 1, b;

            do
            {
                switch (a)
                {
                    case 1:
                        UP();
                        break;
                    case 2:
                        RIGHT();
                        break;
                    case 3:
                        DOWN();
                        break;
                    case 4:
                        LEFT();
                        break;
                }
                count++;
                while (true)
                {
                    b = rand.Next(1, 5);
                    if (Math.Abs(b - a) != 2)
                    {
                        a = b;
                        break;
                    }
                }
            } while (count != t);
            return Value;
        }

        // Tìm vị trí ô trống
        public int PosBlank(int[] val)
        {
            int pos = 0;
            for (int i = 0; i < val.Length; i++)
            {
                if (val[i] == 0)
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }

        // Kiểm tra trạng thái có phải trạng thái đích không
        public bool IsGoal(State goalState)
        {
            int[] goalValue = goalState.Value;
            for (int i = 0; i < length; i++)
            {
                if (Value[i] != goalValue[i])
                {
                    return false;
                }
            }
            return true;
        }

        // Tính ước lượng h(x)
        public int Estimate(State goalState)
        {
            if (Heuristic == 1)
            {
                return Heuristic1(goalState);
            }
            else if (Heuristic == 2)
            {
                return Heuristic2(goalState);
            }
            else if (Heuristic == 3)
            {
                return Heuristic3(goalState);
            }
            else if (Heuristic == 4)
            {
                return Heuristic4(goalState);
            }
            else if (Heuristic == 5)
            {
                return Heuristic5(goalState);
            }
            else if (Heuristic == 6)
            {
                return Heuristic6(goalState);
            }
            else
            {
                return 0; // Giá trị mặc định
            }
        }


        // Heuristic 1 - Tổng số ô sai vị trí
        public int Heuristic1(State goalState)
        {
            int[] goalValue = goalState.Value;
            int distance = 0;
            for (int i = 0; i < length; i++)
            {
                if (Value[i] != 0 && Value[i] != goalValue[i]) distance++;
            }
            return distance;
        }

        // Heuristic 2 - Tổng khoảng cách để đưa các ô về đúng vị trí
        public int Heuristic2(State goalState)
        {
            int[] goalValue = goalState.Value;
            int distance = 0;
            for (int i = 0; i < length; i++)
            {
                if (Value[i] != 0)
                {
                    int gi = Array.IndexOf(goalValue, Value[i]);
                    distance += Math.Abs(gi / size - i / size) + Math.Abs(gi % size - i % size);
                }
            }
            return distance;
        }

        // Heuristic 3 - Tổng khoảng cách Euclid của các ô với vị trí đích
        public int Heuristic3(State goalState)
        {
            int[] goalValue = goalState.Value;
            int distance = 0;
            for (int i = 0; i < length; i++)
            {
                if (Value[i] != 0)
                {
                    int gi = Array.IndexOf(goalValue, Value[i]);
                    int width = Math.Abs(gi % size - i % size);
                    int height = Math.Abs(gi / size - i / size);
                    distance += (int)Math.Sqrt(width * width + height * height);
                }
            }
            return distance;
        }

        // Heuristic 4 - Tổng số ô sai hàng và số ô sai cột
        public int Heuristic4(State goalState)
        {
            int[] goalValue = goalState.Value;
            int distance = 0;
            for (int i = 0; i < length; i++)
            {
                if (Value[i] != 0)
                {
                    int gi = Array.IndexOf(goalValue, Value[i]);
                    if ((gi / size) != (i / size)) distance++;
                    if ((gi % size) != (i % size)) distance++;
                }
            }
            return distance;
        }

        // Heuristic 5 - Tổng khoảng cách để đưa các ô về đúng vị trí + số ô xung đột tuyến tính
        public int Heuristic5(State goalState)
        {
            int[] goalValue = goalState.Value;
            int distance = Heuristic2(goalState);

            // Tính số xung đột tuyến tính trên hàng
            for (int i = 0; i < size; i++)
            {
                int max = -1;
                for (int j = 0; j < size; j++)
                {
                    int c = Value[i * size + j];
                    int gi = Array.IndexOf(goalValue, c);
                    if (c != 0 && gi / size == i)
                    {
                        if (c > max) max = c;
                        else distance += 2;
                    }
                }
            }

            // Tính số xung đột tuyến tính trên cột
            for (int i = 0; i < size; i++)
            {
                int max = -1;
                for (int j = 0; j < size; j++)
                {
                    int c = Value[i + j * size];
                    int gi = Array.IndexOf(goalValue, c);
                    if (c != 0 && gi % size == i)
                    {
                        if (c > max) max = c;
                        else distance += 2;
                    }
                }
            }
            return distance;
        }

        // Heuristic 6 - Heuristic 5 + Số ô không thể về đích
        public int Heuristic6(State goalState)
        {
            int[] goalValue = goalState.Value;
            int distance = Heuristic5(goalState);
            for (int i = 0; i < length; i++)
            {
                if (Value[i] != 0)
                {
                    int c = Value[i];
                    int gi = Array.IndexOf(goalValue, c);
                    int block = 0; // Số ô vuông đúng vị trí xung quanh
                    int count = 0; // Số ô vuông xung quanh
                    if (i != gi)
                    {
                        if (gi / size != 0)
                        {
                            count++;
                            block += Value[gi - size] == goalValue[gi - size] ? 1 : 0;
                        }
                        if (gi / size != size - 1)
                        {
                            count++;
                            block += Value[gi + size] == goalValue[gi + size] ? 1 : 0;
                        }
                        if (gi % size != 0)
                        {
                            count++;
                            block += Value[gi - 1] == goalValue[gi - 1] ? 1 : 0;
                        }
                        if (gi % size != size - 1)
                        {
                            count++;
                            block += Value[gi + 1] == goalValue[gi + 1] ? 1 : 0;
                        }
                    }
                    if (count >= 2 && count == block) distance++;
                }
            }
            return distance;
        }

        // Vector các trạng thái con
        public List<State> Successors()
        {
            List<State> states = new List<State>();
            int blank = PosBlank(Value);
            if (blank / size > 0)
            {
                AddSuccessor(blank, blank - size, states, Value);
            }
            if (blank / size < size - 1)
            {
                AddSuccessor(blank, blank + size, states, Value);
            }
            if (blank % size > 0)
            {
                AddSuccessor(blank, blank - 1, states, Value);
            }
            if (blank % size < size - 1)
            {
                AddSuccessor(blank, blank + 1, states, Value);
            }
            return states;
        }

        // Thêm trạng thái con
        private void AddSuccessor(int blank, int swap, List<State> states, int[] value)
        {
            int[] temp = (int[])value.Clone();
            temp[blank] = temp[swap];
            temp[swap] = 0;
            states.Add(new State(temp, size));
        }

        // Di chuyển ô trống lên trên
        public void UP()
        {
            blank = PosBlank(Value);
            if (blank >= size) // Kiểm tra xem ô trống không phải ở hàng đầu tiên
            {
                Swap(blank, blank - size); // Hoán đổi ô trống với ô ở trên
                blank -= size; // Cập nhật vị trí ô trống
            }
        }

        // Di chuyển ô trống sang phải
        public void RIGHT()
        {
            blank = PosBlank(Value);
            if (blank % size != size - 1) // Kiểm tra xem ô trống không phải ở cột cuối
            {
                Swap(blank, blank + 1); // Hoán đổi ô trống với ô bên phải
                blank += 1; // Cập nhật vị trí ô trống
            }
        }

        // Di chuyển ô trống xuống dưới
        public void DOWN()
        {
            blank = PosBlank(Value);
            if (blank < length - size) // Kiểm tra xem ô trống không phải ở hàng cuối
            {
                Swap(blank, blank + size); // Hoán đổi ô trống với ô ở dưới
                blank += size; // Cập nhật vị trí ô trống
            }
        }

        // Di chuyển ô trống sang trái
        public void LEFT()
        {
            blank = PosBlank(Value);
            if (blank % size != 0) // Kiểm tra xem ô trống không phải ở cột đầu
            {
                Swap(blank, blank - 1); // Hoán đổi ô trống với ô bên trái
                blank -= 1; // Cập nhật vị trí ô trống
            }
        }

        // Hoán đổi vị trí của ô trống và ô khác
        private void Swap(int a, int b)
        {
            int temp = Value[a];
            Value[a] = Value[b];
            Value[b] = temp;
        }
    }
}
