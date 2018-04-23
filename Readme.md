# How to drop a grid column header onto another control


<p>To drop a grid column header onto another control, handle the GridView.DragObjectDrop and GridView.DragObjectOver events.  </p><p>We've prepared a special DragDropHelper class that handles all target control events and processes dropped objects. </p><p>Please note that the DragEnter and DragOver events are handled in order to support dropping objects from another application. You can remove them safely if you don't need this functionality.</p>

<br/>


