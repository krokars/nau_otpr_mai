using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OTPR_C_SHARP_FinForm
{
    internal class Computation
    {

        static double[,] normalization(double[,] matrix)
        {
            int size = matrix.GetLength(0);
            double[] columnSums = new double[size];

            // Шаг 1: Суммируем каждый столбец
            for (int j = 0; j < size; j++)
            {
                columnSums[j] = 0;
                for (int i = 0; i < size; i++)
                {
                    columnSums[j] += matrix[i, j];
                }
            }

            // Шаг 2: Нормализуем матрицу (делим каждый элемент на сумму его столбца)
            double[,] normalizedMatrix = new double[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    normalizedMatrix[i, j] = matrix[i, j] / columnSums[j];
                }
            }

            return normalizedMatrix;
        }

        static double[] compute_global_prioriy(double[] priorities, double[,] global_priority_matrix)
        {

            int numCriteria = priorities.Length;
            int numAlternatives = global_priority_matrix.GetLength(1);

            // Массив для хранения окончательных приоритетов для каждой альтернативы
            double[] final_priorities = new double[numAlternatives];

            // Шаг 1: Вычисление окончательных приоритетов
            for (int i = 0; i < numCriteria; i++) // Проход по критериям
            {
                for (int j = 0; j < numAlternatives; j++) // Проход по альтернативам
                {
                    // Умножаем приоритеты альтернатив по критерию на приоритет критерия
                    final_priorities[j] += priorities[i] * global_priority_matrix[j, i];
                }
            }

            return final_priorities;
        }

        static double[] computer_priorities(double[,] normalized_matrix)
        {
            // Шаг 3: Вычисляем приоритеты (средние значения по строкам)
            int size = normalized_matrix.GetLength(0);
            double[] priorities = new double[size];
            for (int i = 0; i < size; i++)
            {
                priorities[i] = 0;
                for (int j = 0; j < size; j++)
                {
                    priorities[i] += normalized_matrix[i, j];
                }
                priorities[i] /= size; // Среднее значение по строке
            }

            return priorities;
        }
        public static double[] compute_result(double[,] criteria_matrix, List<double[,]> alternatives_matrix)
        {
            criteria_matrix = normalization(criteria_matrix);
            double[] priorities = computer_priorities(criteria_matrix);

            for (int i = 0; i < alternatives_matrix.Count; i++)
                alternatives_matrix[i] = normalization(alternatives_matrix[i]);

            List<double[]> alternatives_priority_list = new List<double[]>();
            for (int i = 0; i < alternatives_matrix.Count; i++)
                alternatives_priority_list.Add(computer_priorities(alternatives_matrix[i]));

             double[,] global_priority = new double[alternatives_matrix.Count, alternatives_matrix.Count];
            //List<double[]> global_priority = new List<double[]>();
            for (int i = 0;i < alternatives_matrix.Count;i++)
            {
                for (int j = 0; j < criteria_matrix.GetLength(0); j++)
                {
                    global_priority[j, i] = alternatives_priority_list[i][j];

                }
            }

            return compute_global_prioriy(priorities, global_priority);
        }
    }
}
