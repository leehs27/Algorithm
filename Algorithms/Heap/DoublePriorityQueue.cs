﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Algorithms.Heap
{
    /// <summary>
    /// https://programmers.co.kr/learn/courses/30/lessons/42628
    /// Heap
    /// </summary>
    public class DoublePriorityQueue
    {
        /// <summary>
        /// 이중 우선순위 큐는 다음 연산을 할 수 있는 자료구조를 말합니다.
        /// 
        /// 명령어  수신 탑(높이)
        /// I ?    큐에 주어진 숫자를 삽입합니다.
        /// D 1    큐에서 최댓값을 삭제합니다.
        /// D -1   큐에서 최솟값을 삭제합니다.
        /// 
        /// 제한사항
        /// operations는 길이가 1 이상 1,000,000 이하인 문자열 배열입니다.
        /// operations의 원소는 큐가 수행할 연산을 나타냅니다.
        /// 원소는 “명령어 데이터” 형식으로 주어집니다.
        /// 최댓값/최솟값을 삭제하는 연산에서 최댓값/최솟값이 둘 이상인 경우, 하나만 삭제합니다.
        /// 
        /// 빈 큐에 데이터를 삭제하라는 연산이 주어질 경우, 해당 연산은 무시합니다.
        /// </summary>
        /// <param name="operations">이중 우선순위 큐가 할 연산</param>
        /// <returns>모든 연산을 처리한 후 큐가 비어있으면 [0,0] 비어있지 않으면 [최댓값, 최솟값]</returns>
        public static int[] Solution(string[] operations)
        {
            Heap<int> heap = new Heap<int>(HeapType.Max);

            foreach(string operation in operations)
            {
                string[] splittedOperation = operation.Split(' ');

                switch(splittedOperation[0])
                {
                    case "I":
                        heap.Add(int.Parse(splittedOperation[1]));
                        break;
                    case "D":
                        if(heap.Count <= 0)
                            break;
                        heap.ChangeHeapType(int.Parse(splittedOperation[1]) > 0 ? HeapType.Max : HeapType.Min);
                        heap.Remove();
                        break;
                }
            }

            heap.ChangeHeapType(HeapType.Max);
            int max = heap.Count > 0 ? heap.Peek() : 0;
            heap.ChangeHeapType(HeapType.Min);
            int min = heap.Count > 0 ? heap.Peek() : 0;

            return new int[] { max, min };
        }
    }
}