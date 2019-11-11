using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace List_2_59
{
    public class MultiplyToAdd : ExpressionVisitor
    {
        public Expression Modify(Expression expression)
        {
            return Visit(expression);
        }
        protected override Expression VisitBinary(BinaryExpression b)
        {
            if (b.NodeType == ExpressionType.Multiply)
            {
                Expression left = this.Visit(b.Left);
                Expression right = this.Visit(b.Right);
                // Make this binary expression an Add rather than a multiply operation.
                return Expression.Add(left, right);
            }
            return base.VisitBinary(b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // build the expression tree:
            // Expression<Func<int,int>> square = num => num * num;
            // The parameter for the expression is an integer
            ParameterExpression numParam = Expression.Parameter(typeof(int), "num");
            // The opertion to be performed is to square the parameter
            BinaryExpression squareOperation = Expression.Multiply(numParam, numParam);
            // This creates an expression tree that describes the square operation
            Expression<Func<int, int>> square = Expression.Lambda<Func<int, int>>(squareOperation, new ParameterExpression[] { numParam });
            MultiplyToAdd m = new MultiplyToAdd();
            Expression<Func<int, int>> addExpression = (Expression<Func<int, int>>)m.Modify(square);
            Func<int, int> doAdd = addExpression.Compile();
            Console.WriteLine("Double of 4: {0}", doAdd(4));
            Console.ReadKey();
        }
    }
}
