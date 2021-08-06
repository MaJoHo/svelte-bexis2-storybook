<script >
 import { Col, Row } from 'sveltestrap';
 import PrismCode from './PrismCode.svelte'
 export let stacked = false;
 export let source;
 export let title;
</script>

<div class="py-3">
 {#if title}
   <h2>{title}</h2>
 {/if} <slot name="info" />
 <div >
  
  <slot name="external" ></slot>
 </div>
 <div class="border p-3">
   <h6 class="text-muted">EXAMPLE</h6>
   <Row>
     <Col md={stacked ? 12 : 5}>
       <slot />
     </Col>
     {#if source}
       <Col md={stacked ? 12 : 7}>
        <PrismCode class="language-html h-100">{source}</PrismCode>
        <PrismCode class="language-aspnet h-100">private class text</PrismCode>
       </Col>
     {/if}
   </Row>
 </div>
</div>