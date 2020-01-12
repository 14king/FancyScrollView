﻿/*
 * FancyScrollView (https://github.com/setchi/FancyScrollView)
 * Copyright (c) 2019 setchi
 * Licensed under MIT (https://github.com/setchi/FancyScrollView/blob/master/LICENSE)
 */

using System;

namespace FancyScrollView
{
    /// <summary>
    /// <see cref="FancyGridView{TItemData, TContext}"/> のコンテキストインターフェース.
    /// </summary>
    public interface IFancyGridViewContext : IFancyScrollRectContext, IFancyCellGroupContext
    {
        ScrollDirection ScrollDirection { get; set; }
        Func<float> GetStartAxisSpacing { get; set; }
        Func<float> GetCellSize { get; set ; }
    }
}
