(function(e){function t(t){for(var n,u,i=t[0],s=t[1],c=t[2],l=0,d=[];l<i.length;l++)u=i[l],Object.prototype.hasOwnProperty.call(a,u)&&a[u]&&d.push(a[u][0]),a[u]=0;for(n in s)Object.prototype.hasOwnProperty.call(s,n)&&(e[n]=s[n]);f&&f(t);while(d.length)d.shift()();return o.push.apply(o,c||[]),r()}function r(){for(var e,t=0;t<o.length;t++){for(var r=o[t],n=!0,u=1;u<r.length;u++){var s=r[u];0!==a[s]&&(n=!1)}n&&(o.splice(t--,1),e=i(i.s=r[0]))}return e}var n={},a={app:0},o=[];function u(e){return i.p+"js/"+({}[e]||e)+"."+{"chunk-08a1fd74":"8e4ab7b5"}[e]+".js"}function i(t){if(n[t])return n[t].exports;var r=n[t]={i:t,l:!1,exports:{}};return e[t].call(r.exports,r,r.exports,i),r.l=!0,r.exports}i.e=function(e){var t=[],r=a[e];if(0!==r)if(r)t.push(r[2]);else{var n=new Promise((function(t,n){r=a[e]=[t,n]}));t.push(r[2]=n);var o,s=document.createElement("script");s.charset="utf-8",s.timeout=120,i.nc&&s.setAttribute("nonce",i.nc),s.src=u(e);var c=new Error;o=function(t){s.onerror=s.onload=null,clearTimeout(l);var r=a[e];if(0!==r){if(r){var n=t&&("load"===t.type?"missing":t.type),o=t&&t.target&&t.target.src;c.message="Loading chunk "+e+" failed.\n("+n+": "+o+")",c.name="ChunkLoadError",c.type=n,c.request=o,r[1](c)}a[e]=void 0}};var l=setTimeout((function(){o({type:"timeout",target:s})}),12e4);s.onerror=s.onload=o,document.head.appendChild(s)}return Promise.all(t)},i.m=e,i.c=n,i.d=function(e,t,r){i.o(e,t)||Object.defineProperty(e,t,{enumerable:!0,get:r})},i.r=function(e){"undefined"!==typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(e,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(e,"__esModule",{value:!0})},i.t=function(e,t){if(1&t&&(e=i(e)),8&t)return e;if(4&t&&"object"===typeof e&&e&&e.__esModule)return e;var r=Object.create(null);if(i.r(r),Object.defineProperty(r,"default",{enumerable:!0,value:e}),2&t&&"string"!=typeof e)for(var n in e)i.d(r,n,function(t){return e[t]}.bind(null,n));return r},i.n=function(e){var t=e&&e.__esModule?function(){return e["default"]}:function(){return e};return i.d(t,"a",t),t},i.o=function(e,t){return Object.prototype.hasOwnProperty.call(e,t)},i.p="/",i.oe=function(e){throw console.error(e),e};var s=window["webpackJsonp"]=window["webpackJsonp"]||[],c=s.push.bind(s);s.push=t,s=s.slice();for(var l=0;l<s.length;l++)t(s[l]);var f=c;o.push([0,"chunk-vendors"]),r()})({0:function(e,t,r){e.exports=r("cd49")},"034f":function(e,t,r){"use strict";var n=r("85ec"),a=r.n(n);a.a},"85ec":function(e,t,r){},cd49:function(e,t,r){"use strict";r.r(t);r("e260"),r("e6cf"),r("cca6"),r("a79d");var n=r("2b0e"),a=function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("div",{attrs:{id:"app"}},[r("b-navbar",{staticClass:"navbar navbar-expand-sm navbar-dark",attrs:{toggleable:"lg",variant:"success"}},[r("a",{staticClass:"navbar-brand",attrs:{href:"#"}},[e._v(" Chucknorris Jokes ")]),r("b-navbar-toggle",{attrs:{target:"mynav1"}}),r("b-collapse",{attrs:{id:"mynav1","is-nav":""}},[r("b-navbar-nav",[r("b-nav-item",[r("router-link",{staticClass:"nav-link",attrs:{"router-link":"",to:"/norris"}},[e._v("Norris")])],1)],1)],1)],1),r("router-view")],1)},o=[],u=(r("034f"),r("2877")),i={},s=Object(u["a"])(i,a,o,!1,null,null,null),c=s.exports,l=(r("d3b7"),r("8c4f"));n["default"].use(l["a"]);var f=[{path:"/",name:"Norris",component:function(){return r.e("chunk-08a1fd74").then(r.bind(null,"d010"))}},{path:"/Norris",name:"Norris",component:function(){return r.e("chunk-08a1fd74").then(r.bind(null,"d010"))}}],d=new l["a"]({mode:"history",base:"/",routes:f}),p=d,v=r("2f62");n["default"].use(v["a"]);var b=new v["a"].Store({state:{},mutations:{},actions:{},modules:{}}),h=r("5f5b"),m=r("b1e0");r("2dd8"),r("f9e3");n["default"].use(h["a"]),n["default"].use(m["a"]),n["default"].config.productionTip=!1,new n["default"]({router:p,store:b,render:function(e){return e(c)}}).$mount("#app")}});
//# sourceMappingURL=app.81c6823d.js.map