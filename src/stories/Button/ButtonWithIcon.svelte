<script>

  import { Button } from 'sveltestrap'  
  import Fa from 'svelte-fa/src/fa.svelte'

  import { faSave } from '@fortawesome/free-solid-svg-icons'
  import { faEye } from '@fortawesome/free-solid-svg-icons'
  import { faPen } from '@fortawesome/free-solid-svg-icons'
  import { faTrash } from '@fortawesome/free-solid-svg-icons'


</script>


<Button><Fa icon={faSave}/></Button>
<Button><Fa icon={faEye}/></Button>
<Button><Fa icon={faPen}/></Button>
<Button><Fa icon={faTrash}/></Button>
