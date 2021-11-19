<!-- DataTable.stories.svelte -->

<script>
 import { Meta, Story } from '@storybook/addon-svelte-csf';
 import Default from './Default.svelte'
 import sourceDefault  from '!!raw-loader!./Default.svelte'

 import DataTable from './DataTable.svelte'
 import sourceDataTable  from '!!raw-loader!./DataTable.svelte'

 import sourceServerSideSvelte  from '!!raw-loader!./ServerSide/ServerSide.svelte'
 import sourceServerSideCSharp  from '!!raw-loader!./ServerSide/Server.cs'
 import sourceServerSideModel  from '!!raw-loader!./ServerSide/Model.cs'

 import Example from '../../Example.svelte'

</script>

<Meta title="Bexis2/Frontend/DataTable" 
 component={DataTable}
/>

<Story name="Default Setup" stacked >
<Example title="Default Setup" svelte={sourceDefault} stacked>
 <Default/> 
</Example>
</Story>

<Story name="With Functions"  >
 <Example title="WithFunctions" svelte={sourceDataTable} stacked>
  <DataTable/> 
 </Example>
</Story>

<Story name="Server"  >
 <Example title="Server" 
  svelte={sourceServerSideSvelte} 
  csharp={sourceServerSideCSharp} 
  model = {sourceServerSideModel}
  stacked 
  codeonly>

  <span slot="external">
   <a href="https://datatables.net/manual/server-side">https://datatables.net/manual/server-side</a>
  </span>
  <!-- <ServerSide/>  -->
  <span slot="info">
   How to load data from server with a bexis 2 ui model.
  </span>
 </Example>
</Story>
