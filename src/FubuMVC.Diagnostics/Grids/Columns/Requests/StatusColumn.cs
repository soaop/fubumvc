﻿using FubuMVC.Diagnostics.Models.Requests;

namespace FubuMVC.Diagnostics.Grids.Columns.Requests
{
	public class StatusColumn : GridColumnBase<RecordedRequestModel>
	{
		public StatusColumn()
			: base("Status")
		{
		}

		public override int Rank()
		{
			return 3;
		}

		public override string ValueFor(RecordedRequestModel target)
		{
			return target.Status();
		}
	}
}