<!-- DataTable.stories.svelte -->

<script>
 import { Meta, Story } from '@storybook/addon-svelte-csf';
 import Default from './Default.svelte'
 import sourceDefault  from '!!raw-loader!./Default.svelte'

 import DataTable from './DataTable.svelte'
 import sourceDataTable  from '!!raw-loader!./DataTable.svelte'

 import Example from '../Example.svelte'

</script>

<Meta title="Bexis2/DataTable" 
 component={DataTable}
/>

<Story name="Default Table"  >
<Example title="Default" source={sourceDefault}>
 <Default/> 
</Example>
</Story>

<Story name="Default Table2"  >
 <Example title="Default2" source={sourceDataTable}>
  <DataTable/> 
 </Example>
</Story>


