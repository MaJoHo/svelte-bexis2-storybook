<script>
 import {Treeview} from '@bexis2/svelte-bexis2-core-ui';
 import data from './data.json'

 let args = {
 showcheckbox:true,
 showcount:true,
 data}

</script>

<Treeview {...args} />


