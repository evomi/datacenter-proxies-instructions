# Datacenter Proxies

[![Evomi Datacenter Proxies Banner](https://my.evomi.com/images/brand/cta.png)](https://evomi.com/?utm_source=github&utm_medium=banner&utm_campaign=github_datacenter)


Welcome to Evomi's Datacenter Proxies repository! This project demonstrates how to use our high-performance datacenter proxies in various programming languages.

## What are Datacenter Proxies?
Datacenter proxies are IP addresses that come from secondary corporations and data centers. They are not affiliated with ISPs and offer high speed and performance. While they may not provide the same level of anonymity as residential proxies, they are excellent for tasks requiring speed and reliability.

## Getting Started
Before running any of the example scripts, you need to set up your credentials:

```bash
export proxy_username=your_username
export proxy_password=your_password
```

Replace `your_username` and `your_password` with the credentials provided by Evomi.

## Protocol
Please note, these examples use the HTTP proxy on `dcp.evomi.com:2000`. Evomi also supports HTTPS on `dcp.evomi-proxy.com:2001` — a different hostname, because that is the one our TLS certificate covers — and SOCKS5 on `dcp.evomi.com:2002`. See [Proxy Protocols](https://docs.evomi.com/proxy-instructions/proxy-protocols/) for the full detail.

## Usage Examples
We provide example scripts in 6 different programming languages to help you get started quickly:

### cURL
```bash
curl -x dcp.evomi.com:2000 -U "${proxy_username}:${proxy_password}" https://ip.evomi.com/s
```

### Python
```bash
python python-example-dc.py
```

### Node.js
```bash
node nodejs-example-dc.js
```

### PHP
```bash
php php-example-dc.php
```

### Go
```bash
go run go-example-dc.go
```

### Java
```bash
javac JavaExampleDC.java
java JavaExampleDC
```

### C#
```bash
dotnet run
```

## Features
- High-performance datacenter IP addresses
- Free Trial
- Based in Switzerland
- Multiple locations available
- High speed and reliability
- 24/7 customer support
- Flexible pricing plans

## Support
If you encounter any issues or have questions, please don't hesitate to contact our support team at hello@evomi.com or via our live-chat.

## P.S.
We are hiring (Sales and Developers)! Send us an email or contact us otherwise 🤫

## License
Apache License 2.0 - see [LICENSE](LICENSE) for details.
