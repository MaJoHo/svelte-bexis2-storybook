<script >
 import { Col, Row, TabContent, TabPane } from 'sveltestrap';
 import PrismCode from './PrismCode.svelte'
 export let stacked = false;
 export let svelte;
 export let csharp;
 export let model;
 export let json;
 export let xml;
 export let title;
 export let codeonly = false;
</script>



<div class="py-3">
 {#if title}
   <h2>{title}</h2>
 {/if} <slot name="info" />
 <div >
  
  <slot name="external" ></slot>
 </div>
 <div class="border p-3">
  <Row>
    <Col md={stacked ? 12 : 5}>
    
    </Col>
    <Col md={stacked ? 12 : 5}>
      
      </Col>
  </Row>
   <Row>
     {#if !codeonly}
     <Col md={stacked ? 12 : 5}>
       <h6 class="text-muted">EXAMPLE</h6>
       <slot />
     </Col>
     {/if}
     <!-- {#if svelte} only if  svelte component exist, then show the tab -->
       <Col md={stacked ? 12 : 7}>
        <!-- <h6 class="text-muted">CODE</h6> -->
        <TabContent pills >

          <TabPane tabId="svelte" tab="Svelte" active>
            <PrismCode class="language-html" >{svelte}</PrismCode>
          </TabPane>

          {#if json}
            <TabPane tabId="json" tab="JSON" >
              <PrismCode class="language-json" >{json}</PrismCode>
            </TabPane>
          {/if}
          {#if csharp}
            <TabPane tabId="csharp" tab="C#" >
              <PrismCode class="language-csharp" >{csharp}</PrismCode>
            </TabPane>
          {/if}
          {#if model}
            <TabPane tabId="csharp model" tab="C# Model" >
              <PrismCode class="language-csharp" >{model}</PrismCode>
            </TabPane>
          {/if}
          {#if xml}
          <TabPane tabId="xml" tab="xml" >
            <PrismCode class="language-xml" >{xml}</PrismCode>
          </TabPane>
        {/if}
        </TabContent>
       </Col>
     <!-- {/if} -->
   </Row>
 </div>
</div>

<style>
  .nav-item{
    margin:0px;
  }
</style>
