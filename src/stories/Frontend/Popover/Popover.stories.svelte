<!-- Button.stories.svelte -->

<script>
    import { Meta, Story } from '@storybook/addon-svelte-csf';
    import Placements from './PoppverPlacements.svelte'
    import sourcePlacements from '!!raw-loader!./PoppverPlacements.svelte'
    import Example from '../../Example.svelte';
    import { Button, Popover } from 'sveltestrap';

    const placements = ['top', 'right', 'left', 'bottom'];
   
</script>
   
   <Meta title="Bexis2/Frontend/Popover" 
   />
   
   <Story name="Popover"  >
   <Example title="Placements" svelte={sourcePlacements}>
    <Placements/>
   </Example>
   </Story>

   
   
   
   