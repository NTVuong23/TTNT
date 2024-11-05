using System;

namespace NPuzzleAI
{
    public class Result
    {
        public string Heuristic { get; set; }
        public int Approved { get; set; }
        public int Total { get; set; }
        public long Time { get; set; }
        public int Step { get; set; }
        public string Error { get; set; }

        public Result(string heuristic, int approved, int total, int step, long time, string error)
        {
            Heuristic = heuristic;
            Approved = approved;
            Total = total;
            Step = step;
            Time = time;
            Error = error;
        }

        public string ShowResult()
        {
            string rs = $"Thuật toán sử dụng Heuristic: {Heuristic}\n";
            if (Error == null)
            {
                rs += $"Số node đã duyệt: {Approved}\n" +
                      $"Tổng số node trên cây: {Total}\n" +
                      $"Số bước đi đến đích: {Step}\n" +
                      $"Thời gian tìm kiếm: {Time}ms\n";
            }
            else
            {
                rs += "Không tìm được lời giải\n" +
                      "Nguyên nhân:\n" +
                      "Thuật toán quá tốn thời gian!\n";
            }
            return rs;
        }
    }
}
