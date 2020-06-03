﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Algorithms
{
    /// <summary>
    /// https://programmers.co.kr/learn/courses/30/lessons/42583
    /// Stack and Queue
    /// </summary>
    public static class TruckBridge
    {
        /// <summary>
        /// 트럭 여러 대가 강을 가로지르는 일 차선 다리를 정해진 순으로 건너려 합니다. 
        /// 모든 트럭이 다리를 건너려면 최소 몇 초가 걸리는지 알아내야 합니다. 
        /// 럭은 1초에 1만큼 움직이며, 다리 길이는 bridge_length이고 다리는 무게 weight까지 견딥니다.
        /// ※ 트럭이 다리에 완전히 오르지 않은 경우, 이 트럭의 무게는 고려하지 않습니다.
        /// 
        /// 예를 들어, 길이가 2이고 10kg 무게를 견디는 다리가 있습니다.
        /// 무게가[7, 4, 5, 6] kg인 트럭이 순서대로 최단 시간 안에 다리를 건너려면 다음과 같이 건너야 합니다.
        /// 
        /// 경과 시간    다리를 지난 트럭   다리를 건너는 트럭    대기 트럭
        /// 0	        []              []                  [7,4,5,6]
        /// 1~2	        []              [7]                 [4,5,6]
        /// 3	        [7]             [4]                 [5,6]
        /// 4	        [7]             [4,5]               [6]
        /// 5	        [7,4]           [5]                 [6]
        /// 6~7	        [7,4,5]         [6]                 []
        /// 8	        [7,4,5,6]       []                  []
        /// 
        /// 따라서, 모든 트럭이 다리를 지나려면 최소 8초가 걸립니다.
        /// </summary>
        /// <param name="bridge_length">다리 길이</param>
        /// <param name="weight">다리가 견딜 수 있는 무게</param>
        /// <param name="truck_weights">트럭별 무게</param>
        /// <returns>모든 트럭이 다리를 건너려면 최소 몇 초가 걸리는지</returns>
        public static int Solution(int bridge_length, int weight, int[] truck_weights)
        {
            int time = 0;
            int index = 0;

            Queue<int> bridgeTrucks = new Queue<int>();
            int sum = 0;

            while(index < truck_weights.Length)
            {
                time++;

                if(bridgeTrucks.Count == bridge_length)
                {
                    sum -= bridgeTrucks.Peek();
                    bridgeTrucks.Dequeue();
                }

                if(sum + truck_weights[index] <= weight)
                {
                    sum += truck_weights[index];
                    bridgeTrucks.Enqueue(truck_weights[index]);
                    index++;
                }
                else
                {
                    bridgeTrucks.Enqueue(0);
                }
            }

            time += bridge_length;

            return time;
        }
    }
}
