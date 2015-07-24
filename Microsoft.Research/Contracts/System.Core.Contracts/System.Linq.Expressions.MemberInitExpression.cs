// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Text;

namespace System.Linq.Expressions
{
  // Summary:
  //     Represents calling a constructor and initializing one or more members of
  //     the new object.
  public sealed class MemberInitExpression : Expression
  {
    private MemberInitExpression() { }
    // Summary:
    //     Gets the bindings that describe how to initialize the members of the newly
    //     created object.
    //
    // Returns:
    //     A System.Collections.ObjectModel.ReadOnlyCollection<T> of System.Linq.Expressions.MemberBinding
    //     objects which describe how to initialize the members.
    public ReadOnlyCollection<MemberBinding> Bindings
    {
      get
      {
        Contract.Ensures(Contract.Result<ReadOnlyCollection<MemberBinding>>() != null);
        return default(ReadOnlyCollection<MemberBinding>);
      }
    }
    //
    // Summary:
    //     Gets the expression that represents the constructor call.
    //
    // Returns:
    //     A System.Linq.Expressions.NewExpression that represents the constructor call.
    public NewExpression NewExpression
    {
      get
      {
        Contract.Ensures(Contract.Result<NewExpression>() != null);
        return default(NewExpression);
      }
    }

#if NETFRAMEWORK_4_0 || SILVERLIGHT_4_0 || SILVERLIGHT_5_0
    //
    // Summary:
    //     Creates a new expression that is like this one, but using the supplied children.
    //     If all of the children are the same, it will return this expression.
    //
    // Parameters:
    //   newExpression:
    //     The System.Linq.Expressions.MemberInitExpression.NewExpression property of the
    //     result.
    //
    //   bindings:
    //     The System.Linq.Expressions.MemberInitExpression.Bindings property of the result.
    //
    // Returns:
    //     This expression if no children are changed or an expression with the updated
    //     children.
    [Pure]
    public MemberInitExpression Update(NewExpression newExpression, IEnumerable<MemberBinding> bindings)
    {
      Contract.Requires(newExpression != null);
      Contract.Requires(bindings != null);
      Contract.Ensures(Contract.Result<MemberInitExpression>() != null);
      return default(MemberInitExpression);
    }
#endif
  }
}
