<script>
 import {Treeview} from '@bexis2/svelte-bexis2-core-ui'
 import data from './data.json'

 let target ="_blank";

 let args = {
 href:"api/test/id=",
 checkboxhref:"api/test/id=",
 showcheckbox:true,
 showcount:true,
 target:"_blank", 
 data}
 
</script>

<Treeview {...args} />


