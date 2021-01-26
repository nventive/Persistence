using System;
using System.Reactive;
using System.Reactive.Concurrency;
using Uno.Extensions;

namespace Nventive.Persistence
{
	internal static class ObserverExtensions
	{
		/// <summary>
		/// Launch a "OnNext" of an observer using a scheduler.
		/// </summary>
		internal static IDisposable OnNext<T>(this IObserver<T> observer, IScheduler scheduler, T value)
		{
			scheduler.Validation().NotNull("scheduler");

			return scheduler.Schedule((Action)(() => observer.OnNext(value)));
		}

		/// <summary>
		/// Launch a "OnNext" of an observer using a scheduler.
		/// </summary>
		internal static IDisposable OnNext<T>(this IObserver<T> observer, IScheduler scheduler, Func<T> valueSelector)
		{
			scheduler.Validation().NotNull("scheduler");
			valueSelector.Validation().NotNull("valueSelector");

			return scheduler.Schedule((Action)(() => observer.OnNext(valueSelector())));
		}
	}
}
