<!-- Button.stories.svelte -->

<script>
 import { Meta, Story } from '@storybook/addon-svelte-csf';
 import Color from './ButtonColor.svelte'
 import Size from './ButtonSize.svelte'
 import Icon from './ButtonWithIcon.svelte'
 import sourceColor  from '!!raw-loader!./ButtonColor.svelte'
 import sourceSize  from '!!raw-loader!./ButtonSize.svelte'
 import sourceIcon  from '!!raw-loader!./ButtonWithIcon.svelte'
 import Example from '../../Example.svelte'

</script>

<Meta title="Bexis2/Frontend/Button" 
 component={Color}
/>

<Story name="Colors"  >
<Example title="Color" svelte={sourceColor}>
 <Color/> 
 <span slot="info">
  This story shows all the colors of the different buttons.
 </span>
</Example>
</Story>

<Story name="Size"  >
 <Example title="Size" svelte={sourceSize}>
  <Size/> 
  <span slot="info">
   Easy change size.
  </span>
 </Example>
 </Story>

<Story name="Icon"  >
 <Example title="Icon" svelte={sourceIcon}>
  <Icon/> 
  <span slot="info">
   Button with icons are used as grid functions in bexis 2.
  </span>
 </Example>
 </Story>



