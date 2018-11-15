<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [DataHelper.cs](./CS/Helpers/DataHelper.cs) (VB: [DataHelper.vb](./VB/Helpers/DataHelper.vb))
* [BaseDropGridColumnHeaderSupportHelper.cs](./CS/Helpers/DragDrop/BaseDropGridColumnHeaderSupportHelper.cs) (VB: [BaseDropGridColumnHeaderSupportHelper.vb](./VB/Helpers/DragDrop/BaseDropGridColumnHeaderSupportHelper.vb))
* [ChartControlHelper.cs](./CS/Helpers/DragDrop/ChartControlHelper.cs) (VB: [ChartControlHelper.vb](./VB/Helpers/DragDrop/ChartControlHelper.vb))
* [DragDropHelper.cs](./CS/Helpers/DragDrop/DragDropHelper.cs) (VB: [DragDropHelper.vb](./VB/Helpers/DragDrop/DragDropHelper.vb))
* [IDropGridColumnHeaderSupport.cs](./CS/Helpers/DragDrop/IDropGridColumnHeaderSupport.cs) (VB: [IDropGridColumnHeaderSupport.vb](./VB/Helpers/DragDrop/IDropGridColumnHeaderSupport.vb))
* [ListBoxControlHelper.cs](./CS/Helpers/DragDrop/ListBoxControlHelper.cs) (VB: [ListBoxControlHelper.vb](./VB/Helpers/DragDrop/ListBoxControlHelper.vb))
* [PivotGridControlHelper.cs](./CS/Helpers/DragDrop/PivotGridControlHelper.cs) (VB: [PivotGridControlHelper.vb](./VB/Helpers/DragDrop/PivotGridControlHelper.vb))
* [TreeListHelper.cs](./CS/Helpers/DragDrop/TreeListHelper.cs) (VB: [TreeListHelper.vb](./VB/Helpers/DragDrop/TreeListHelper.vb))
<!-- default file list end -->
# How to drop a grid column header onto another control


<p>To drop a grid column header onto another control, handle the GridView.DragObjectDrop and GridView.DragObjectOver events.  </p><p>We've prepared a special DragDropHelper class that handles all target control events and processes dropped objects. </p><p>Please note that the DragEnter and DragOver events are handled in order to support dropping objects from another application. You can remove them safely if you don't need this functionality.</p>

<br/>


