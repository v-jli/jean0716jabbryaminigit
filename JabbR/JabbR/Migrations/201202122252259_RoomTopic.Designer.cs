namespace JabbR.Models.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class RoomTopic : IDbMigrationMetadata
    {
        string IDbMigrationMetadata.Id
        {
            get { return "201202122252259_RoomTopic"; }
        }
        
        string IDbMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IDbMigrationMetadata.Target
        {
            get { return "H4sIAAAAAAAEAOy9B2AcSZYlJi9tynt/SvVK1+B0oQiAYBMk2JBAEOzBiM3mkuwdaUcjKasqgcplVmVdZhZAzO2dvPfee++999577733ujudTif33/8/XGZkAWz2zkrayZ4hgKrIHz9+fB8/Iv7Hv/cffPx7vFuU6WVeN0W1/Oyj3fHOR2m+nFazYnnx2Ufr9nz74KPf4+g3Th6fzhbv0p807fbQjt5cNp99NG/b1aO7d5vpPF9kzXhRTOuqqc7b8bRa3M1m1d29nZ2Du7s7d3MC8RHBStPHr9bLtljk/Af9eVItp/mqXWflF9UsLxv9nL55zVDTF9kib1bZNP/so+9kk8mrsbT7KD0ui4xweJ2X5++J0M5DIPSR7Yo6OyWk2us316ucO/zso5N51p6URb5s/XbU8vfKr4MP6KOXdbXK6/b6VX6ub1Ojj9K74Yt3u2/a9/yXgMJnH50t23t7H6Uv1mWZTUr64Dwrm/yjdPXpo9dtVeef58u8ztp89jJr27ymaTmb5TwEJcWj1ae3o8bDuzt7oMbdbLms2qylOe5h3sHzbGbQfN3WxCwfpc+Kd/nseb68aOcW1S+yd+YT+vWj9KtlQbxFL7X1OveHJn9v7vKrJq+PLzAZP+yen2dNezxti0umrXT+lCj/hnj4y/PzJm8j09QB+SK7LC6YtJFhfZS+ykv+spkXK+HnseO+31/aPKurxasKXXS++v1fV+t6Sn2+qeLfv8nqCyDp4/T4ruP3G6WAEfiRDPycywD+/aF3+u2smf/QO32dlT98QcdIwUtNc1XVP/zZ3aRnbtYwEWAv1rOL3I4jBuo2aL0mcVg3N4nkDYxbte/LuCSUH0jP4/O3Pyf9njXUs+n1SUUqOVu+N8WeldnF+2L+oXhb3fle3X44458usqL82e910AaTA7rMp2RGxGg2H2qPjb0dssfGXt8Wvy+vlvnsVVUthjHDt78/2tVNFzPvqyhm/vfvi9lmpHiw2iTEyX0TdV68r2O+yyaMjsuyuroVtbQl+orTzG8wTLmgVYx+7+VpAeSPPK2fNVv2c+JAnZRV41D/ugbhTbUqpu+J+8GHmrKXdXGZORP6dXE/W5JPk58QGu85gK9B/Js0g8r7N6cZYgpsWH/cFtuTOs9I8DYjahtFcNTvhtEzDd4XM2NlPswSDaLVsVS3xeqLvGmyi3wYL23AZqWLmP9dVNMHDd7XSG7muFsZyRhOERv6tc2Oju9HlqfvGbY/Fymnn4Pcwnfn+bJrXj84uyXC9qESGdMVUZG9LVobk24GcszL97/biNaH590o5f5F3mazrM2+jliCgzZKpf9aj+v+Xy2UnP3/IWSlhqbquGmqacGodjz30HMIB3G6nKW3ciNkSL45pVGsy7ZYlcWU0Pnso2/1KHQTcGs/QuDC4huBP77rDfeWVDBuyY049nyUb2jsXdfmFsPeGY93P3zk6vfciGDXCfqGxt2N8m8e9ofNdqDBN2EXV+chesYHec+Bx323mwn6wRMe2InbYBgajW908GHa6eZp/+DBe17rJvxieZ6bsbtp1DHH+OYJ/zBW91N/m3CLrsuFyOma8nsOOppgvJmWuyG2BPbL5dO8zNs8xVoDlvNPsmaaITTv+guEwG0IJlYSrnJWkP5RomGlvmb/+V13/VxeeJ23NkGiaVdnbyPk6lEnBKJRVhSEEOYGABqDRQEIP90AwIWgURhWxG8A4zl+MVC+X9gF5U2QR11jHcK0htd2Y/6jyz639WPssCxlQ2RvAcqwuQdKke9yajjw9yGKTaFsoEfUn4nj3/Vovh4Vuv7LzyYBTKpmw/hjXk0c8Y5f8/VG3/FifpYGH0af8dEP+zc9zKMejoe6Uw43kCDqz9xEyA+kgejHzTToW75B1APj9yE0CIzdzxIfeJ7MAAWGfJ0e2hFv5yakN8H4WZ78YDEzPvJBp6eHdszt8fC2Fv6G0cecnA+YdxPBW9/Efvf47mvOSugHj+9Sk2m+atdZ+QXSC4354otstaLkgvnbfZK+XmVToL39WnMet0t4HNylnMdCYNydBizV9aRsT2QLSBw631LXhOmzom5aytdlkwzpjpPZotfsNp6Y6Sp0yPqTZZwR0x6/O3/v1ViI5/ttHRiOgM9oTAtqwcPTwQmzbHiZXn89zcqsjiWUT6pyvVh6H3S5bfh9pL781/vps01vgy+PL4BwAMT7+PawsNgJz5xWzDpDCr/pQ3x8t0PZ7vR5+Sxt2RGkLjvcilmG3MT3YJWYgrklo8Rf/X8nm+Df8H355PYQJOvpQ5BPbg/hdVZ2uFQ+uT0E9IjEb9NcVXWHHt3vbg/167P9Jogv1rOLvIOj//ntob2m3PS66VBOP7s9lBdV2+UA/uT2EI7P3/aB2A9vD+esoZc6zCwf3R7GszK7CEHIJ7eH4FYNQqkyn94e0ukiK8oQjH70/xpFOeRCvoeijAUit1SU8Vd/thTlNyt8oiY/RHGelFXTxcV8dnsob6pVMQ2B6Ee3h/GyLi6zrgDbD28P52xJCjGHC9gRHu/z/9ewvo38Poj7TQbt6wnA4Ns/WzLALnfXJ7Qf3h7Ohzkdsq7vvy+f/L+GN4J859fmj8HlcgZzE39sfPtnZ14Y774/5338w5+hMJDuxIQmPRemkW8wVp3WQ4ZpyJNHeqArVTHIJufQp9jtJNsCjYo4r4QYEF8XwzeSzvgQDDkt8p4YdrMjX3/ebab8pim3DW/rhmyiYScV/rXJp2Dek3q3w+0Dme/9cSIjMit4gfKsebEuy88+Os/KpuMIbBjyN8cUZvXgJp4w7W5SAP3lyg30D1cbvi75f3ZkP1zE+BDcfs6kPlwhudkv04bv4XsNEDC2BPJ1KfiNzmxskefrIvb+ON1K6ofG2+eID+AIWTO4BUdIw2+OI/yFga9L+K8jT7dD7P+dHDE03m+EI/zVsxsSvKbZUBb3Pb2D/mLb16X711Wyt0HtA3n169qmb2RugwXCGxd6Nsh6fDFngHiRJcCvS71vdFIjK5xfF6/3ROnmyeytc3ab2MBRP7F/23VOXWOUaXXvySopD6TR9c7uoqM0+Sgl3C+LGRYcX183bb4Yo8H49S8qdfptgy+yZXGeN+2b6m1Oq81YE6UF6LLIGll6fq/l1Id3d/bu5rPF3aaZlf6MeKmD3iyGM/eY5qM7GWYiXuXn/ix2NWj3Tfue/xJQ+OyjAiRg6fg8pxmibB+tk7RtXi+ROcg14Q0tnk2wHK6avNNjBz5SDgJ+eZnV03lWby2yd3d8OG29joAJwXgLld8AtHDBRgBSZiVvi0VenZ83JNHvO04nyR4xN8LwUyE3ckU/9fAjnsC/3wggSWZ9A4Be80LlNwCou0r5DYDcxPPvPYP+IskwqNugZVYobys1ETbgdcWQQh+lX2TvnufLi3bO6vt9sbLLld8sWF2/FKCT4v3HKquXm5B6b5SsEH8DPKbrme8N6b1UYd8D//+wKvzmBOkb04Zm0fHrc6muOG5g04P3Fh27/vj10fLXHb8JOvnZy6j6+kBGjyYg/j/M63Zh8Rsg/jfkQshCYyh4X9MBdEHwLXmhD+IGH/ID2Glw9fB27NRfN7yZm9wM/awwE4eBX9NxuzXZjLn5EA/8hgRJ/IXhjNhNZA+7+/peVYjFbeF8bcp2VlV+RNoPI+1wtvL2lN2Qm3q/qbgdZd+fIt/UDA1R1stpefD9XGKIDGXH0ldV6Y3H4ICckc0ykyO0LttiVRZT6vSzj/oLil8un+Zl3uYp4rWKtORJ1kyzWX/4SMhtwsHktTpYmI9DPL7VA0/Tm9fQz1lJtrtpa8rctX1eKJbTYpWV3bF3GkbZJs5edy3M7jdP81W+hMnoD/I23W1Kt1rQHRLfRIQg93kz+/jL8t8M/+yMx7u9qQthufVRD5Z8+P8PHoitysT1lO+0/5wxQbAc/Y1M3C2YwIQTXXD28581Vrj17HwTrDCwbBvtb9PClYX9w2GFb86e/L+aFW6tFTArP0xW+H+LaTguy+oqnwGd+LLx19UQP4tuRhAixXAZYtVvkLF+qDpmOCbkV97PPf455bDY+vXXVTz/P+ewW0/2zxmH/b9Fh315tfz/qPba3chcuz+L3PVzpr96lB1kr/+3KDBlr/8Pqq6fO/a6tR75uWOv/xdoL0YB2N9Kef2/gbvQ3aAiDb/8/wdvBWO6Taf/72OtWyiu/zfYxf83sNatZ/nnjLV+qEbxlPPUWEelN/LaoEFLYc+Kummf0vLeJGv6Wgtvvc7bXhb7o1S+G8gPv57O80VGK6OTihhA8ufu+yaSZOh3JPow2o18NdQJxye36kJ4MNqFfDXUBYvjrbqwiZFoL/bboY60wc19+eu0/b6Cb2N9BQ1uMawwchqk4M2T1XFj3rPr3Vv0vXu7zm8mcV97DTLnzRzkt+p37UlxTPok55d6rXoyGEkLRvW0GQR143/YU0nhm6ESsO+aj7v2IhzOLYfK+tGsdwyMNWjzszVYf67tm/LhNzLQIKc/MNDhvP/XR7f3ZkdX2Zft59/ocDfx8HBu+xuc1x/OcJlFY7nZTSx9Yy73G5z1mCoPIAwR9BsjiLq1tyZIzA22w/pwvvg5IUiY+dpEig05sp8lrrBWNkqFvtX+cDLcgiM25HJ+lnjhh0MGwAozCQNU6Df82SJC6NFEIAxx1YeTYDMj9BvePJtfTxx+NkiAOBpwbFRmv3t8V9xG/YD+JP+GTNIXFK+VDX9KseCa3l7k8tfTvCkuHIjHBHOZcxjvgJo2Z8vzyoSkHYxME/O1TooJDY7rtjjPpi19PSUjWSwvPkp/MivX1OR0MclnZ8sv1+1q3dKQ88WkDEJbBLWb+n98t4fz4y9X+Kv5JoZAaBY0hPzL5ZN1Uc4s3s+ysumY+iEQiJY/z+lzmUsKvtv84tpCelEtbwlIyffUBPlv8sWqJGDNl8vX2WU+jNvNNAwp9vhpkV3U2cKnoHyimLzOqGevC+rAf8P1R38Su84W747+nwAAAP//H9n/x1t/AAA="; }
        }
    }
}
