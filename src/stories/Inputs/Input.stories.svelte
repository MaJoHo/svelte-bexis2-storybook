<script>
 import { Meta, Story } from '@storybook/addon-svelte-csf';
 import Inputs from './Inputs.svelte'
 import sourceInputs from '!!raw-loader!./Inputs.svelte'
 import Validation from './Validation.svelte'
 import sourceValidation from '!!raw-loader!./Validation.svelte'
 import Example from '../Example.svelte'

</script>

<Meta title="Bexis2/Inputs" 
 component={Inputs}
/>

<Story name="Default" >
 <Example title="Inputs" source={sourceInputs}>
  <Inputs/> 
  <span slot="info">
   This story shows input examples.
  </span>
   <div slot="external" style="margin:1rem 0;" >
    <a href="https://sveltestrap.js.org/?path=/story/components--inputs" target="_blank">Sveltestrap Inputs</a>
  </div>    
 </Example>
 </Story>

 <Story name="Validation" >
  <Example title="Validation" source={sourceValidation}>
   <Validation/> 
   <span slot="info">
    This story shows validation examples.
   </span>
    <div slot="external" style="margin:1rem 0;" >
     <a href="https://sveltestrap.js.org/?path=/story/components--inputs" target="_blank">Sveltestrap Inputs</a>
   </div>    
  </Example>
  </Story>
 