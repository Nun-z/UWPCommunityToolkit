﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using Microsoft.Windows.Toolkit.UI.Animations.Extensions;
using Windows.UI.Xaml;

namespace Microsoft.Windows.Toolkit.UI.Animations.Behaviors
{
    /// <summary>
    /// Performs a rotation animation using composition.
    /// </summary>
    public class Rotation : CompositionBehaviorBase
    {
        /// <summary>
        /// The rotation of the associated object in degrees
        /// </summary>
        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(double), typeof(Rotation), new PropertyMetadata(1d, PropertyChangedCallback));

        /// <summary>
        /// The center (x axis) of rotation for associated object
        /// </summary>
        public static readonly DependencyProperty CenterXProperty = DependencyProperty.Register("CenterX", typeof(double), typeof(Rotation), new PropertyMetadata(0d, PropertyChangedCallback));

        /// <summary>
        /// The center (y axis) of rotation for associated object
        /// </summary>
        public static readonly DependencyProperty CenterYProperty = DependencyProperty.Register("CenterY", typeof(double), typeof(Rotation), new PropertyMetadata(0d, PropertyChangedCallback));

        /// <summary>
        /// The center (z axis) of rotation for associated object
        /// </summary>
        public static readonly DependencyProperty CenterZProperty = DependencyProperty.Register("CenterZ", typeof(double), typeof(Rotation), new PropertyMetadata(0d, PropertyChangedCallback));

        /// <summary>
        /// Gets or sets the center point (x axis) of the associated object.
        /// </summary>
        /// <value>
        /// The center point (x axis) of the associated object.
        /// </value>
        public double CenterX
        {
            get { return (double)GetValue(CenterXProperty); }
            set { SetValue(CenterXProperty, value); }
        }

        /// <summary>
        /// Gets or sets the center point (y axis) of the associated object.
        /// </summary>
        /// <value>
        /// The center point (y axis) of the associated object.
        /// </value>
        public double CenterY
        {
            get { return (double)GetValue(CenterYProperty); }
            set { SetValue(CenterYProperty, value); }
        }

        /// <summary>
        /// Gets or sets the center point (z axis) of the associated object.
        /// </summary>
        /// <value>
        /// The center point (z axis) of the associated object.
        /// </value>
        public double CenterZ
        {
            get { return (double)GetValue(CenterZProperty); }
            set { SetValue(CenterZProperty, value); }
        }

        /// <summary>
        /// Gets or sets the Rotation in degrees.
        /// </summary>
        /// <value>
        /// The Rotation of the associated object in degrees.
        /// </value>
        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        /// <summary>
        /// Starts the animation.
        /// </summary>
        public override void StartAnimation()
        {
            AssociatedObject.Rotate(
                duration: Duration,
                delay: Delay,
                value: (float)Value,
                centerX: (float)CenterX,
                centerY: (float)CenterY,
                centerZ: (float)CenterZ);
        }
    }
}