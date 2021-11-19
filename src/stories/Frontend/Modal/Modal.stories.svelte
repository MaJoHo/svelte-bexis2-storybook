<script>

 import Example from '../../Example.svelte'
 import Default from './Default.svelte'
 import DefaultRaw from '!!raw-loader!./Default.svelte'

 import { Meta, Story } from '@storybook/addon-svelte-csf';


</script>

<Meta title="Bexis2/Frontend/Modal" 
component={Default}
/>

<Story name="DefaulModal" >
 <Example title="default modal window example" svelte={DefaultRaw} >
  <Default /> 
  <p slot="info">
   modal window example. pleasae click the button
  </p>
 </Example>
 </Story>