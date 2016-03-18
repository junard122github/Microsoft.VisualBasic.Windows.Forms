' Copyright (c) Microsoft Corporation.  All rights reserved.

Imports System.Drawing
Imports System.Windows
Imports System.Windows.Media.Imaging

Namespace Taskbar
	''' <summary>
	''' Event args for the TabbedThumbnailBitmapRequested event. The event allows applications to
	''' provide a bitmap for the tabbed thumbnail's preview and peek. The application should also
	''' set the Handled property if a custom bitmap is provided.
	''' </summary>
	Public Class TabbedThumbnailBitmapRequestedEventArgs
		Inherits TabbedThumbnailEventArgs
		''' <summary>
		''' Creates a Event Args for a TabbedThumbnailBitmapRequested event.
		''' </summary>
		''' <param name="windowHandle">Window handle for the control/window related to the event</param>
		Public Sub New(windowHandle As IntPtr)
			MyBase.New(windowHandle)
		End Sub

		''' <summary>
		''' Creates a Event Args for a TabbedThumbnailBitmapRequested event.
		''' </summary>
		''' <param name="windowsControl">WPF Control (UIElement) related to the event</param>
		Public Sub New(windowsControl As UIElement)
			MyBase.New(windowsControl)
		End Sub


		''' <summary>
		''' Gets or sets a value indicating whether the TabbedThumbnailBitmapRequested event was handled.
		''' Set this property if the SetImage method is called with a custom bitmap for the thumbnail/peek.
		''' </summary>
		Public Property Handled() As Boolean
			Get
				Return m_Handled
			End Get
			Set
				m_Handled = Value
			End Set
		End Property
		Private m_Handled As Boolean
	End Class
End Namespace
