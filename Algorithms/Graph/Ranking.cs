﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Algorithms
{
    /// <summary>
    /// https://programmers.co.kr/learn/courses/30/lessons/49191
    /// Graph
    /// </summary>
    public class Ranking
    {
        /// <summary>
        /// n명의 권투선수가 권투 대회에 참여했고 각각 1번부터 n번까지 번호를 받았습니다. 
        /// 권투 경기는 1대1 방식으로 진행이 되고, 만약 A 선수가 B 선수보다 실력이 좋다면 A 선수는 B 선수를 항상 이깁니다. 
        /// 심판은 주어진 경기 결과를 가지고 선수들의 순위를 매기려 합니다. 하지만 몇몇 경기 결과를 분실하여 정확하게 순위를 매길 수 없습니다.
        /// 
        /// 제한사항
        /// 선수의 수는 1명 이상 100명 이하입니다.
        /// 경기 결과는 1개 이상 4,500개 이하입니다.
        /// results 배열 각 행 [A, B] 는 A 선수가 B 선수를 이겼다는 의미입니다.
        /// 모든 경기 결과에는 모순이 없습니다.
        /// </summary>
        /// <param name="n">선수의 수</param>
        /// <param name="results">경기 결과를 담은 2차원 배열</param>
        /// <returns>정확하게 순위를 매길 수 있는 선수의 수</returns>
        public static int Solution(int n, int[,] results)
        {
            int answer = 0;
            return answer;
        }
    }
}
