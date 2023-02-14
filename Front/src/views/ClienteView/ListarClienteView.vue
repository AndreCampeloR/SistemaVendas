<template>
  <div class="main-container">
    <TabelaListarCliente/>
  </div>
</template>

<script>
import TabelaListarCliente from '@/components/Cliente/TabelaListarCliente.vue';

export default {
  name: 'ListarClienteView',
  components: {
    TabelaListarCliente
  }
}
</script>