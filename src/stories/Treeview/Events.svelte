<script>
 import {Treeview} from '@bexis2/svelte-bexis2-core-ui';
 import data from './data.json'

 let args = {
 showcheckbox:true,
 showcount:false,
 data}

 function selectionItemHandler(e)
 {
    console.log(e.detail);
 }

 function selectionCheckboxHandler(e)
 {
    alert("selected Checkbox: "+e.detail);
 }
 
</script>

<Treeview {...args} on:selectItem={selectionItemHandler} on:selectcheckbox={selectionCheckboxHandler} />


