using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comment - 4.
            Console.WriteLine("Hello World!!!");
        }
    }
}

// Server
// docker run \
//   --volume=/Users/abe/Documents/drone/data:/data \
//   --env=DRONE_GITHUB_SERVER=https://github.com \
//   --env=DRONE_GITHUB_CLIENT_ID=f2a7ba4a901c2e2dd235 \
//   --env=DRONE_GITHUB_CLIENT_SECRET=fc71bb9346f000d7015c49763bedca7c143939cf \
//   --env=DRONE_AGENTS_ENABLED=true \
//   --env=DRONE_RPC_SECRET=257984415c3a09e491ae76f6d837940c \
//   --env=DRONE_SERVER_HOST=drone.machost \
//   --env=DRONE_SERVER_PROTO=http \
//   --env=DRONE_TLS_AUTOCERT=true \
//   --env=DRONE_LOGS_DEBUG=true \
//   --publish=80:80 \
//   --publish=443:443 \
//   --restart=always \
//   --detach=true \
//   --name=drone \
//   drone/drone:1

// Agent
// docker run --volume=//./pipe/docker_engine://./pipe/docker_engine --env=DRONE_LOGS_DEBUG=true --env=DRONE_RPC_HOST=drone.machost --env=DRONE_RPC_PROTO=http --env=DRONE_RPC_DEBUG=true --env=DRONE_RPC_SECRET=257984415c3a09e491ae76f6d837940c --env=DRONE_RUNNER_CAPACITY=2 --restart=always --detach=true --name=agent drone/agent:windows-1803-amd64