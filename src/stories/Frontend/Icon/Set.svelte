<script>
  import Fa from 'svelte-fa/src/fa.svelte'

  import { faAngleDown } from '@fortawesome/free-solid-svg-icons'
  import { faAngleRight } from '@fortawesome/free-solid-svg-icons'
  import { faAddressBook } from '@fortawesome/free-solid-svg-icons'
  import { Row,Col } from 'sveltestrap';


</script>



<Row>
 <Col xs=2> 
  <Fa icon={faAngleRight} />
 </Col>
 <Col> 
  <b>faAngleRight</b> - fa-angle-right
 </Col>
</Row>

<Row>
 <Col xs=2> 
  <Fa icon={faAngleDown}/>
 </Col>
 <Col> 
  <b>faAngleDown</b> - fa-angle-down
 </Col>
</Row>

<Row>
 <Col xs=2> 
  <Fa icon={faAddressBook}/>
 </Col>
 <Col> 
  <b>faAddressBook</b> - fa-adress-book
 </Col>
</Row>


