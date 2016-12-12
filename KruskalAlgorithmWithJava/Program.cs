using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KruskalAlgorithmWithJava
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5,5];
        int[] parent = new int[5];
        int min;
        int u=0;
        int v=0;
        int noOfEdges = 1;
        int total = 0;
        int input = Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<input;i++)
        {
            parent[i]=0;
            for(int j=0;j<input;j++)
            {
                //matrix[i][j]=scan.nextInt();
                matrix[i,j]=Convert.ToInt32(Console.ReadLine());
                if(matrix[i,j]==0)
                {
                    matrix[i,j]=999;
                }
            }
        }
        while (noOfEdges < input)
        {
            min=999;
            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    if(matrix[i,j]<min)
                    {
                        min=matrix[i,j];
                        u=i;
                        v=j;
                    }
                }
            }
            if(parent[u]!=0)
            {
                u=parent[u];
            }
            if(parent[v]!=0)
            {
                v=parent[v];
            }
            if(v!=u)
            {
                noOfEdges++;
                //System.out.println("Edge fount : "+u+"->"+v+"Min : "+min);
                Console.WriteLine("Edge fount : "+u+"->"+v+"Min : "+min);
                total = total+min;
                parent[v]=u;
            }
            matrix[u,v]=matrix[v,u]=999;
        }
        //System.out.println("The minimum weight of the tree is : "+total);
        Console.WriteLine("The minimum weight of the tree is : " + total);
        }
    }
}
