using System.Collections.Generic;
using UnityEngine;

public abstract class SingleOperatorTest : ITest
{
    public abstract uint Operate(float f);

    public int Execute(IReadOnlyList<FloatInputs.Input> inputs, int[] indices, ref uint[] results)
    {
        float f = inputs[indices[0]].Float;

        results[0] = Operate(f);

        return 1;
    }
}

public class Sin : SingleOperatorTest
{
    public override uint Operate(float f) => FloatTools.FloatToBits(RapierMath.Sin(f));
}

public class Cos : SingleOperatorTest
{
    public override uint Operate(float f) => FloatTools.FloatToBits(RapierMath.Cos(f));
}

public class Tan : SingleOperatorTest
{
    public override uint Operate(float f) => FloatTools.FloatToBits(RapierMath.Tan(f));
}

public class Asin : SingleOperatorTest
{
    public override uint Operate(float f) => FloatTools.FloatToBits(RapierMath.Asin(f));
}

public class Acos : SingleOperatorTest
{
    public override uint Operate(float f) => FloatTools.FloatToBits(RapierMath.Acos(f));
}

public class Atan : SingleOperatorTest
{
    public override uint Operate(float f) => FloatTools.FloatToBits(RapierMath.Atan(f));
}


