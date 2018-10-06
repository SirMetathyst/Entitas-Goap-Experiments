using System;

public static partial class ContextExtensions
{
    public static AIEntity AddAction (this AIContext context, int cost, IGoapState<string, object> condition, IGoapState<string, object> effect, Func<GoapActionStatus> action)
    {
        var entity = context.CreateEntity ();
        entity.AddCost (cost);
        entity.AddGoapCondition (condition);
        entity.AddGoapEffect (effect);
        entity.AddGoapAction (action);
        return entity;
    }

    public static void AddTestActions (this AIContext context)
    {
        context.AddTestAction1 ();
        context.AddTestAction2 ();
        context.AddTestAction2Dot5 ();
        context.AddTestAction3 ();
        context.AddTestAction4 ();
        context.AddTestAction5 ();
    }

    public static AIEntity AddTestAction1 (this AIContext context)
    {
        var condition = new GoapState<string, object> () { };

        var effect = new GoapState<string, object> ()
            {
                ["HasAction1"] = true
            };

        return context.AddAction (0, condition, effect, () =>
        {
            Console.WriteLine ("[ACTION 1]");

            return GoapActionStatus.Success;
        });
    }

    public static AIEntity AddTestAction2 (this AIContext context)
    {
        var condition = new GoapState<string, object> ()
            {
                ["HasAction1"] = true
            };

        var effect = new GoapState<string, object> ()
            {
                ["HasAction2"] = true
            };

        return context.AddAction (0, condition, effect, () =>
        {
            Console.WriteLine ("[ACTION 2]");

            return GoapActionStatus.Success;
        });
    }

    public static AIEntity AddTestAction2Dot5 (this AIContext context)
    {
        var condition = new GoapState<string, object> ()
            {
                ["HasAction1"] = true
            };

        var effect = new GoapState<string, object> ()
            {
                ["HasAction2"] = true
            };

        return context.AddAction (0, condition, effect, () =>
        {
            Console.WriteLine ("[ACTION 2.5]");

            return GoapActionStatus.Success;
        });
    }

    public static AIEntity AddTestAction3 (this AIContext context)
    {
        var condition = new GoapState<string, object> ()
            {
                ["HasAction2"] = true
            };

        var effect = new GoapState<string, object> ()
            {
                ["HasAction3"] = true
            };

        return context.AddAction (0, condition, effect, () =>
        {
            Console.WriteLine ("[ACTION 3]");

            return GoapActionStatus.Success;
        });
    }

    public static AIEntity AddTestAction4 (this AIContext context)
    {
        var condition = new GoapState<string, object> ()
            {
                ["HasAction3"] = true
            };

        var effect = new GoapState<string, object> ()
            {
                ["HasAction4"] = true
            };

        return context.AddAction (0, condition, effect, () =>
        {
            Console.WriteLine ("[ACTION 4]");

            return GoapActionStatus.Success;
        });
    }

    public static AIEntity AddTestAction5 (this AIContext context)
    {
        var condition = new GoapState<string, object> ()
            {
                ["HasAction4"] = true
            };

        var effect = new GoapState<string, object> ()
            {
                ["HasAction5"] = true
            };

        return context.AddAction (0, condition, effect, () =>
        {
            Console.WriteLine ("[ACTION 5]");

            return GoapActionStatus.Success;
        });
    }
}