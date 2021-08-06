TreeView.stories.svelte

<script>
 import { Meta, Template, Story } from '@storybook/addon-svelte-csf';

//  import {Treeview} from '@bexis2/svelte-bexis2-core-ui/';
 import {Button} from '@bexis2/svelte-bexis2-core-ui/';
 import Data from './Data.svelte';
 import sourceData from '!!raw-loader!./Data.svelte';
 import Options from './Options.svelte';
 import sourceOption from '!!raw-loader!./Options.svelte';
 import Example from '../Example.svelte'

 let argTypes={
    data: { control: "object" },
    href: { control: "text" },
    checkboxhref: { control: "text" },
    target: { control: "text" },
    showcheckbox: { control: "boolean" },
    showcount: { control: "boolean" }
  }


  let data =[{
      "label": "Test",
      "description":"description of a",
      "count": 2,
      "value": "A",
      "active":false,
      "href":"http://www.google.de",
      "items": [
        {
        "label": "A1",
        "description":"description of a1",
        "count": 1,
        "value": "1",
        "active":false,
        "items": []
        },
        {
        "label": "A2",
        "description":"description of a2",
        "count": 1,
        "value": "2",
        "active":false,
        "items": [
            {
            "label": "underlaying",
            "description":"description of underlaying",
            "count": 1,
            "value": "underlaying",
            "active":false,
            "items": []
            }
          ]
        }
      ]
  }]

</script>


<Meta title="Bexis2/Treeview" 
component={Button}
/>

<!-- 
<Story name="Data">
 <Example title="Data" source={sourceData}>
  <Data /> 
  <p slot="info">
   This story shows all the colors of the different buttons.
  </p>
 </Example>
 </Story>

 <Story name="Option"  >
  <Example title="Option" source={sourceOption}>
   <Options/> 
   <span slot="info">
    This story shows all the colors of the different buttons.
   </span>
  </Example>
  </Story> -->

  <Story name="Playground">
    <Button></Button>
  </Story>



