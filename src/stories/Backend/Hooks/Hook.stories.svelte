<script>
 import { Meta, Story } from '@storybook/addon-svelte-csf';
 import Example from '../../Example.svelte'
 import Hook from './hook.svelte'
 import sourceHook from '!!raw-loader!./hook.svelte'
 import sourceHookCSharp from '!!raw-loader!./hook.cs'
 import sourceHookXml from '!!raw-loader!./hooks.xml'

</script>

<Meta title="Bexis2/Backend/Hooks" component={Hook}/>

 <Story name="hook default" >
  <Example 
    title="hook default example"
    svelte={sourceHook}
    model = {sourceHookCSharp}
    xml = {sourceHookXml}
  >   
  <Hook/>
  <span slot="info">
    How hooks look like.
   </span>
  </Example>
</Story>
